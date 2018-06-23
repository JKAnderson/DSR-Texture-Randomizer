using Octokit;
using Semver;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace DSR_Texture_Randomizer
{
    public partial class FormMain : Form
    {
        private const string UPDATE_LINK = "https://www.nexusmods.com/darksoulsremastered/mods/67?tab=files";
        private static Properties.Settings settings = Properties.Settings.Default;

        private TPUP tpup;
        private Thread tpupThread;
        private bool abort = false;

        public FormMain()
        {
            InitializeComponent();
        }

        private void enableControls(bool enable)
        {
            txtGameDir.Enabled = enable;
            btnGameBrowse.Enabled = enable;
            btnGameExplore.Enabled = enable;
            txtUnpackDir.Enabled = enable;
            btnUnpackBrowse.Enabled = enable;
            btnUnpackExplore.Enabled = enable;
            txtCustomDir.Enabled = enable;
            btnCustomBrowse.Enabled = enable;
            btnCustomExplore.Enabled = enable;
            btnAbort.Enabled = !enable;
            btnRestore.Enabled = enable;
            btnUnpack.Enabled = enable;
            btnRandomize.Enabled = enable;
            gbxRandomInput.Enabled = enable;
            gbxRandomOutput.Enabled = enable;
            nudThreads.Enabled = enable;
        }

        private void appendLog(string line)
        {
            if (txtLog.TextLength > 0)
                txtLog.AppendText("\r\n");
            txtLog.AppendText(line);
        }

        private async void FormMain_Load(object sender, EventArgs e)
        {
            Text = "DSR Texture Randomizer " + System.Windows.Forms.Application.ProductVersion;
            Location = settings.WindowLocation;
            Size = settings.WindowSize;
            if (settings.WindowMaximized)
                WindowState = FormWindowState.Maximized;

            txtGameDir.Text = settings.GameDirectory;
            txtUnpackDir.Text = settings.UnpackDirectory;
            cbxChrIn.Checked = settings.CheckChrIn;
            cbxMapIn.Checked = settings.CheckMapIn;
            cbxObjIn.Checked = settings.CheckObjIn;
            cbxPartsIn.Checked = settings.CheckPartsIn;
            cbxSfxIn.Checked = settings.CheckSfxIn;
            cbxCustomIn.Checked = settings.CheckCustomIn;
            cbxChrOut.Checked = settings.CheckChrOut;
            cbxMapOut.Checked = settings.CheckMapOut;
            cbxObjOut.Checked = settings.CheckObjOut;
            cbxPartsOut.Checked = settings.CheckPartsOut;
            cbxSfxOut.Checked = settings.CheckSfxOut;

            if (settings.Threads == 0)
            {
                int cores = Environment.ProcessorCount;
                if (cores > 4)
                    nudThreads.Value = cores - 2;
                else if (cores > 1)
                    nudThreads.Value = cores - 1;
                else
                    nudThreads.Value = 1;
            }
            else
                nudThreads.Value = settings.Threads;
            nudThreads.Maximum = Environment.ProcessorCount;

            enableControls(true);

            GitHubClient gitHubClient = new GitHubClient(new ProductHeaderValue("DSR-Texture-Randomizer"));
            try
            {
                Release release = await gitHubClient.Repository.Release.GetLatest("JKAnderson", "DSR-Texture-Randomizer");
                if (SemVersion.Parse(release.TagName) > System.Windows.Forms.Application.ProductVersion)
                {
                    lblUpdate.Visible = false;
                    LinkLabel.Link link = new LinkLabel.Link();
                    link.LinkData = UPDATE_LINK;
                    llbUpdate.Links.Add(link);
                    llbUpdate.Visible = true;
                }
                else
                {
                    lblUpdate.Text = "App up to date";
                }
            }
            catch (Exception ex) when (ex is HttpRequestException || ex is ApiException || ex is ArgumentException)
            {
                lblUpdate.Text = "Update status unknown";
            }
        }

        private void llbUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData.ToString());
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tpupThread != null && tpupThread.IsAlive)
            {
                tpup.Stop();
                e.Cancel = true;
                abort = true;
            }
            else
            {
                settings.WindowMaximized = WindowState == FormWindowState.Maximized;
                if (WindowState == FormWindowState.Normal)
                {
                    settings.WindowLocation = Location;
                    settings.WindowSize = Size;
                }
                else
                {
                    settings.WindowLocation = RestoreBounds.Location;
                    settings.WindowSize = RestoreBounds.Size;
                }

                settings.GameDirectory = txtGameDir.Text;
                settings.UnpackDirectory = txtUnpackDir.Text;
                settings.CheckChrIn = cbxChrIn.Checked;
                settings.CheckMapIn = cbxMapIn.Checked;
                settings.CheckObjIn = cbxObjIn.Checked;
                settings.CheckPartsIn = cbxPartsIn.Checked;
                settings.CheckSfxIn = cbxSfxIn.Checked;
                settings.CheckCustomIn = cbxCustomIn.Checked;
                settings.CheckChrOut = cbxChrOut.Checked;
                settings.CheckMapOut = cbxMapOut.Checked;
                settings.CheckObjOut = cbxObjOut.Checked;
                settings.CheckPartsOut = cbxPartsOut.Checked;
                settings.CheckSfxOut = cbxSfxOut.Checked;
                settings.Threads = (int)nudThreads.Value;
            }
        }

        private string browseClick(string path, bool newFolder, string description)
        {
            fbdBrowse.Description = description;
            try
            {
                fbdBrowse.SelectedPath = Path.GetFullPath(path);
            }
            catch (ArgumentException)
            {
                fbdBrowse.SelectedPath = "";
            }
            fbdBrowse.ShowNewFolderButton = newFolder;

            if (fbdBrowse.ShowDialog() == DialogResult.OK)
                path = fbdBrowse.SelectedPath;
            return path;
        }

        private void btnGameBrowse_Click(object sender, EventArgs e)
        {
            txtGameDir.Text = browseClick(txtGameDir.Text, false, "Select your game install directory");
        }

        private void btnUnpackBrowse_Click(object sender, EventArgs e)
        {
            txtUnpackDir.Text = browseClick(txtUnpackDir.Text, true, "Select the directory to unpack textures into");
        }

        private void btnCustomBrowse_Click(object sender, EventArgs e)
        {
            txtCustomDir.Text = browseClick(txtCustomDir.Text, true, "Select the directory to load custom textures from");
        }

        private void exploreClick(string path)
        {
            if (Directory.Exists(path))
                Process.Start(Path.GetFullPath(path));
            else
                SystemSounds.Hand.Play();
        }

        private void btnGameExplore_Click(object sender, EventArgs e)
        {
            exploreClick(txtGameDir.Text);
        }

        private void btnUnpackExplore_Click(object sender, EventArgs e)
        {
            exploreClick(txtUnpackDir.Text);
        }

        private void btnCustomExplore_Click(object sender, EventArgs e)
        {
            exploreClick(txtCustomDir.Text);
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            tpup.Stop();
            btnAbort.Enabled = false;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtGameDir.Text))
            {
                MessageBox.Show("Game directory not found:\n" + txtGameDir.Text,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtLog.Clear();
                int found = 0;
                foreach (string filepath in Directory.GetFiles(txtGameDir.Text, "*.trbak", SearchOption.AllDirectories))
                {
                    string newPath = Path.GetDirectoryName(filepath) + "\\" + Path.GetFileNameWithoutExtension(filepath);
                    if (File.Exists(newPath))
                        File.Delete(newPath);
                    File.Move(filepath, newPath);
                    found++;
                }

                if (found > 0)
                    appendLog(found + " backups restored.");
                else
                    appendLog("No backups found.");
            }
        }

        private void btnUnpack_Click(object sender, EventArgs e)
        {
            string unpackDir;
            try
            {
                unpackDir = Path.GetFullPath(txtUnpackDir.Text);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Invalid output path:\n" + txtUnpackDir.Text,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Directory.Exists(txtGameDir.Text))
            {
                MessageBox.Show("Game directory not found:\n" + txtGameDir.Text,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = DialogResult.OK;
                if (Directory.Exists(txtUnpackDir.Text))
                {
                    result = MessageBox.Show("The contents of this directory will be deleted:\n" + unpackDir,
                        "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                }

                if (result == DialogResult.OK)
                {
                    bool proceed = true;

                    try
                    {
                        if (Directory.Exists(unpackDir))
                        {
                            appendLog("Deleting unpack directory...");
                            Directory.Delete(unpackDir, true);
                        }
                    }
                    catch (Exception ex) when (ex is IOException || ex is UnauthorizedAccessException)
                    {
                        MessageBox.Show("Unpack directory could not be deleted. Try running as Administrator.\n"
                            + "Reason: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        proceed = false;
                    }

                    try
                    {
                        if (proceed)
                        {
                            Directory.CreateDirectory(unpackDir);
                            File.WriteAllText(unpackDir + "\\tpup_test.txt",
                                "Test file to see if TPUP can write to this directory.");
                            File.Delete(unpackDir + "\\tpup_test.txt");
                        }
                    }
                    catch (Exception ex) when (ex is IOException || ex is UnauthorizedAccessException)
                    {
                        MessageBox.Show("Unpack directory could not be written to. Try running as Administrator.\n"
                            + "Reason: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        proceed = false;
                    }

                    if (proceed)
                    {
                        enableControls(false);
                        txtLog.Clear();
                        pbrProgress.Value = 0;
                        pbrProgress.Maximum = 0;
                        tpup = new TPUP(txtGameDir.Text, unpackDir, false, null, (int)nudThreads.Value);
                        tpupThread = new Thread(tpup.Start);
                        tpupThread.Start();
                    }
                }
            }
        }

        private void btnRandomize_Click(object sender, EventArgs e)
        {
            string gameDir = txtGameDir.Text;
            string unpackDir = txtUnpackDir.Text;

            if (!Directory.Exists(gameDir))
            {
                MessageBox.Show("Game directory not found:\n" + gameDir,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Directory.Exists(unpackDir))
            {
                MessageBox.Show("Unpacked directory not found:\n" + unpackDir,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool proceed = true;
                unpackDir = Path.GetFullPath(unpackDir);
                try
                {
                    File.WriteAllText(unpackDir + "\\tpup_test.txt",
                        "Test file to see if TPUP can write to this directory.");
                    File.Delete(unpackDir + "\\tpup_test.txt");
                }
                catch (Exception ex) when (ex is IOException || ex is UnauthorizedAccessException)
                {
                    MessageBox.Show("Unpack directory could not be written to. Try running as Administrator.\n"
                            + "Reason: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    proceed = false;
                }

                if (proceed)
                {
                    Dictionary<string, string> swaps = null;
                    if (!(cbxChrIn.Checked || cbxMapIn.Checked || cbxObjIn.Checked || cbxPartsIn.Checked || cbxSfxIn.Checked || cbxCustomIn.Checked))
                    {
                        MessageBox.Show("You must check at least one input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!(cbxChrOut.Checked || cbxMapOut.Checked || cbxObjOut.Checked || cbxPartsOut.Checked || cbxSfxOut.Checked))
                    {
                        MessageBox.Show("You must check at least one output.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        swaps = getTextureSwaps(unpackDir, txtCustomDir.Text);

                    if (swaps != null)
                    {
                        enableControls(false);
                        txtLog.Clear();
                        pbrProgress.Value = 0;
                        pbrProgress.Maximum = 0;

                        tpup = new TPUP(gameDir, unpackDir, true, swaps, (int)nudThreads.Value);
                        tpupThread = new Thread(tpup.Start);
                        tpupThread.Start();
                    }
                }
            }
        }

        private Dictionary<string, string> getTextureSwaps(string unpackDir, string customDir)
        {
            List<string> inTextures = new List<string>();
            if (cbxChrIn.Checked)
            {
                addTextures(unpackDir, "chr", inTextures, false);
                addTextures(unpackDir, "facegen", inTextures, false);
            }
            if (cbxMapIn.Checked)
                addTextures(unpackDir, "map", inTextures, false);
            if (cbxObjIn.Checked)
                addTextures(unpackDir, "obj", inTextures, false);
            if (cbxPartsIn.Checked)
                addTextures(unpackDir, "parts", inTextures, false);
            if (cbxSfxIn.Checked)
                addTextures(unpackDir, "sfx", inTextures, false);
            if (cbxCustomIn.Checked)
                addTextures(customDir, ".", inTextures, false);

            if (inTextures.Count == 0)
            {
                MessageBox.Show("No input textures found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            List<string> outTextures = new List<string>();
            if (cbxChrOut.Checked)
            {
                addTextures(unpackDir, "chr", outTextures, true);
                addTextures(unpackDir, "facegen", outTextures, true);
            }
            if (cbxMapOut.Checked)
                addTextures(unpackDir, "map", outTextures, true);
            if (cbxObjOut.Checked)
                addTextures(unpackDir, "obj", outTextures, true);
            if (cbxPartsOut.Checked)
                addTextures(unpackDir, "parts", outTextures, true);
            if (cbxSfxOut.Checked)
                addTextures(unpackDir, "sfx", outTextures, true);

            if (outTextures.Count == 0)
            {
                MessageBox.Show("No output textures found. Please unpack the game textures first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            Random rand = new Random();
            List<string> buffer = new List<string>();
            Dictionary<string, string> swaps = new Dictionary<string, string>();
            foreach (string outPath in outTextures)
            {
                if (buffer.Count == 0)
                    buffer.AddRange(inTextures);

                int pick = rand.Next(0, buffer.Count);
                swaps[outPath] = buffer[pick];
                buffer.RemoveAt(pick);
            }

            return swaps;
        }

        private static void addTextures(string unpackDir, string subDir, List<string> textures, bool strip)
        {
            if (Directory.Exists(unpackDir + "\\" + subDir))
            {
                foreach (string path in Directory.GetFiles(unpackDir + "\\" + subDir, "*", SearchOption.AllDirectories))
                {
                    string extension = Path.GetExtension(path).ToLower();
                    if (validExtensions.Contains(extension))
                    {
                        bool valid = true;
                        foreach (Regex rx in blacklist)
                        {
                            if (rx.IsMatch(Path.GetFileNameWithoutExtension(path)))
                                valid = false;
                        }

                        if (valid)
                        {
                            if (strip)
                            {
                                string strippedPath = path.Substring(unpackDir.Length + 1);
                                strippedPath = strippedPath.Substring(0, strippedPath.Length - extension.Length);
                                textures.Add(strippedPath);
                            }
                            else
                                textures.Add(path);
                        }
                    }
                }
            }
        }

        private static List<string> validExtensions = new List<string>
        {
            ".bmp",
            ".dds",
            ".jpeg",
            ".jpg",
            ".png",
            ".tga",
            ".tif",
            ".tiff",
        };

        private static List<Regex> blacklist = new List<Regex>
        {
            new Regex("_n$"),
            new Regex("_s$"),
            new Regex("_lit_"),
            new Regex("Env")
        };

        private void updateLogs()
        {
            while (tpup.Log.TryDequeue(out string line))
                appendLog(line);

            while (tpup.Error.TryDequeue(out string line))
                appendLog(line);

            if (pbrProgress.Maximum == 0)
                pbrProgress.Maximum = tpup.GetProgressMax();
            else
                pbrProgress.Value = tpup.GetProgress();
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            if (tpupThread != null)
            {
                if (tpupThread.IsAlive)
                {
                    updateLogs();
                }
                else
                {
                    updateLogs();

                    tpup = null;
                    tpupThread = null;
                    pbrProgress.Maximum = 0;
                    pbrProgress.Value = 0;
                    enableControls(true);

                    if (abort)
                        Close();
                    else
                        SystemSounds.Asterisk.Play();
                }
            }
        }
    }
}
