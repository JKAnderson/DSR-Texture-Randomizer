namespace DSR_Texture_Randomizer
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.lblGameDir = new System.Windows.Forms.Label();
            this.txtGameDir = new System.Windows.Forms.TextBox();
            this.txtUnpackDir = new System.Windows.Forms.TextBox();
            this.lblUnpackDir = new System.Windows.Forms.Label();
            this.gbxRandomInput = new System.Windows.Forms.GroupBox();
            this.cbxSfxIn = new System.Windows.Forms.CheckBox();
            this.cbxPartsIn = new System.Windows.Forms.CheckBox();
            this.cbxObjIn = new System.Windows.Forms.CheckBox();
            this.cbxMapIn = new System.Windows.Forms.CheckBox();
            this.cbxChrIn = new System.Windows.Forms.CheckBox();
            this.btnGameBrowse = new System.Windows.Forms.Button();
            this.btnGameExplore = new System.Windows.Forms.Button();
            this.btnUnpackBrowse = new System.Windows.Forms.Button();
            this.btnUnpackExplore = new System.Windows.Forms.Button();
            this.btnRandomize = new System.Windows.Forms.Button();
            this.btnUnpack = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.pbrProgress = new System.Windows.Forms.ProgressBar();
            this.fbdBrowse = new System.Windows.Forms.FolderBrowserDialog();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.lblUpdate = new System.Windows.Forms.Label();
            this.llbUpdate = new System.Windows.Forms.LinkLabel();
            this.gbxRandomOutput = new System.Windows.Forms.GroupBox();
            this.cbxSfxOut = new System.Windows.Forms.CheckBox();
            this.cbxPartsOut = new System.Windows.Forms.CheckBox();
            this.cbxObjOut = new System.Windows.Forms.CheckBox();
            this.cbxMapOut = new System.Windows.Forms.CheckBox();
            this.cbxChrOut = new System.Windows.Forms.CheckBox();
            this.lblThreads = new System.Windows.Forms.Label();
            this.nudThreads = new System.Windows.Forms.NumericUpDown();
            this.btnCustomExplore = new System.Windows.Forms.Button();
            this.btnCustomBrowse = new System.Windows.Forms.Button();
            this.txtCustomDir = new System.Windows.Forms.TextBox();
            this.lblCustomDir = new System.Windows.Forms.Label();
            this.cbxCustomIn = new System.Windows.Forms.CheckBox();
            this.gbxRandomInput.SuspendLayout();
            this.gbxRandomOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreads)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGameDir
            // 
            this.lblGameDir.AutoSize = true;
            this.lblGameDir.Location = new System.Drawing.Point(12, 9);
            this.lblGameDir.Name = "lblGameDir";
            this.lblGameDir.Size = new System.Drawing.Size(80, 13);
            this.lblGameDir.TabIndex = 0;
            this.lblGameDir.Text = "Game Directory";
            // 
            // txtGameDir
            // 
            this.txtGameDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGameDir.Location = new System.Drawing.Point(12, 25);
            this.txtGameDir.Name = "txtGameDir";
            this.txtGameDir.Size = new System.Drawing.Size(591, 20);
            this.txtGameDir.TabIndex = 1;
            this.txtGameDir.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\DARK SOULS REMASTERED";
            // 
            // txtUnpackDir
            // 
            this.txtUnpackDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnpackDir.Location = new System.Drawing.Point(12, 64);
            this.txtUnpackDir.Name = "txtUnpackDir";
            this.txtUnpackDir.Size = new System.Drawing.Size(591, 20);
            this.txtUnpackDir.TabIndex = 3;
            this.txtUnpackDir.Text = "Unpacked Textures";
            // 
            // lblUnpackDir
            // 
            this.lblUnpackDir.AutoSize = true;
            this.lblUnpackDir.Location = new System.Drawing.Point(12, 48);
            this.lblUnpackDir.Name = "lblUnpackDir";
            this.lblUnpackDir.Size = new System.Drawing.Size(90, 13);
            this.lblUnpackDir.TabIndex = 2;
            this.lblUnpackDir.Text = "Unpack Directory";
            // 
            // gbxRandomInput
            // 
            this.gbxRandomInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxRandomInput.AutoSize = true;
            this.gbxRandomInput.Controls.Add(this.cbxCustomIn);
            this.gbxRandomInput.Controls.Add(this.cbxSfxIn);
            this.gbxRandomInput.Controls.Add(this.cbxPartsIn);
            this.gbxRandomInput.Controls.Add(this.cbxObjIn);
            this.gbxRandomInput.Controls.Add(this.cbxMapIn);
            this.gbxRandomInput.Controls.Add(this.cbxChrIn);
            this.gbxRandomInput.Location = new System.Drawing.Point(690, 171);
            this.gbxRandomInput.Name = "gbxRandomInput";
            this.gbxRandomInput.Size = new System.Drawing.Size(75, 170);
            this.gbxRandomInput.TabIndex = 4;
            this.gbxRandomInput.TabStop = false;
            this.gbxRandomInput.Text = "Inputs";
            // 
            // cbxSfxIn
            // 
            this.cbxSfxIn.AutoSize = true;
            this.cbxSfxIn.Location = new System.Drawing.Point(6, 111);
            this.cbxSfxIn.Name = "cbxSfxIn";
            this.cbxSfxIn.Size = new System.Drawing.Size(39, 17);
            this.cbxSfxIn.TabIndex = 4;
            this.cbxSfxIn.Text = "sfx";
            this.cbxSfxIn.UseVisualStyleBackColor = true;
            // 
            // cbxPartsIn
            // 
            this.cbxPartsIn.AutoSize = true;
            this.cbxPartsIn.Checked = true;
            this.cbxPartsIn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxPartsIn.Location = new System.Drawing.Point(6, 88);
            this.cbxPartsIn.Name = "cbxPartsIn";
            this.cbxPartsIn.Size = new System.Drawing.Size(49, 17);
            this.cbxPartsIn.TabIndex = 3;
            this.cbxPartsIn.Text = "parts";
            this.cbxPartsIn.UseVisualStyleBackColor = true;
            // 
            // cbxObjIn
            // 
            this.cbxObjIn.AutoSize = true;
            this.cbxObjIn.Checked = true;
            this.cbxObjIn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxObjIn.Location = new System.Drawing.Point(6, 65);
            this.cbxObjIn.Name = "cbxObjIn";
            this.cbxObjIn.Size = new System.Drawing.Size(40, 17);
            this.cbxObjIn.TabIndex = 2;
            this.cbxObjIn.Text = "obj";
            this.cbxObjIn.UseVisualStyleBackColor = true;
            // 
            // cbxMapIn
            // 
            this.cbxMapIn.AutoSize = true;
            this.cbxMapIn.Checked = true;
            this.cbxMapIn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxMapIn.Location = new System.Drawing.Point(6, 42);
            this.cbxMapIn.Name = "cbxMapIn";
            this.cbxMapIn.Size = new System.Drawing.Size(46, 17);
            this.cbxMapIn.TabIndex = 1;
            this.cbxMapIn.Text = "map";
            this.cbxMapIn.UseVisualStyleBackColor = true;
            // 
            // cbxChrIn
            // 
            this.cbxChrIn.AutoSize = true;
            this.cbxChrIn.Checked = true;
            this.cbxChrIn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxChrIn.Location = new System.Drawing.Point(6, 19);
            this.cbxChrIn.Name = "cbxChrIn";
            this.cbxChrIn.Size = new System.Drawing.Size(41, 17);
            this.cbxChrIn.TabIndex = 0;
            this.cbxChrIn.Text = "chr";
            this.cbxChrIn.UseVisualStyleBackColor = true;
            // 
            // btnGameBrowse
            // 
            this.btnGameBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGameBrowse.Location = new System.Drawing.Point(609, 23);
            this.btnGameBrowse.Name = "btnGameBrowse";
            this.btnGameBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnGameBrowse.TabIndex = 5;
            this.btnGameBrowse.Text = "Browse";
            this.btnGameBrowse.UseVisualStyleBackColor = true;
            this.btnGameBrowse.Click += new System.EventHandler(this.btnGameBrowse_Click);
            // 
            // btnGameExplore
            // 
            this.btnGameExplore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGameExplore.Location = new System.Drawing.Point(690, 23);
            this.btnGameExplore.Name = "btnGameExplore";
            this.btnGameExplore.Size = new System.Drawing.Size(75, 23);
            this.btnGameExplore.TabIndex = 6;
            this.btnGameExplore.Text = "Explore";
            this.btnGameExplore.UseVisualStyleBackColor = true;
            this.btnGameExplore.Click += new System.EventHandler(this.btnGameExplore_Click);
            // 
            // btnUnpackBrowse
            // 
            this.btnUnpackBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnpackBrowse.Location = new System.Drawing.Point(609, 62);
            this.btnUnpackBrowse.Name = "btnUnpackBrowse";
            this.btnUnpackBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnUnpackBrowse.TabIndex = 7;
            this.btnUnpackBrowse.Text = "Browse";
            this.btnUnpackBrowse.UseVisualStyleBackColor = true;
            this.btnUnpackBrowse.Click += new System.EventHandler(this.btnUnpackBrowse_Click);
            // 
            // btnUnpackExplore
            // 
            this.btnUnpackExplore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnpackExplore.Location = new System.Drawing.Point(690, 62);
            this.btnUnpackExplore.Name = "btnUnpackExplore";
            this.btnUnpackExplore.Size = new System.Drawing.Size(75, 23);
            this.btnUnpackExplore.TabIndex = 8;
            this.btnUnpackExplore.Text = "Explore";
            this.btnUnpackExplore.UseVisualStyleBackColor = true;
            this.btnUnpackExplore.Click += new System.EventHandler(this.btnUnpackExplore_Click);
            // 
            // btnRandomize
            // 
            this.btnRandomize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRandomize.Location = new System.Drawing.Point(690, 142);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(75, 23);
            this.btnRandomize.TabIndex = 6;
            this.btnRandomize.Text = "Randomize";
            this.btnRandomize.UseVisualStyleBackColor = true;
            this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
            // 
            // btnUnpack
            // 
            this.btnUnpack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnpack.Location = new System.Drawing.Point(609, 142);
            this.btnUnpack.Name = "btnUnpack";
            this.btnUnpack.Size = new System.Drawing.Size(75, 23);
            this.btnUnpack.TabIndex = 9;
            this.btnUnpack.Text = "Unpack";
            this.btnUnpack.UseVisualStyleBackColor = true;
            this.btnUnpack.Click += new System.EventHandler(this.btnUnpack_Click);
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(12, 171);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(672, 363);
            this.txtLog.TabIndex = 10;
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.Location = new System.Drawing.Point(528, 142);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 11;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbort.Enabled = false;
            this.btnAbort.Location = new System.Drawing.Point(447, 142);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(75, 23);
            this.btnAbort.TabIndex = 12;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // pbrProgress
            // 
            this.pbrProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbrProgress.Location = new System.Drawing.Point(12, 142);
            this.pbrProgress.Name = "pbrProgress";
            this.pbrProgress.Size = new System.Drawing.Size(429, 23);
            this.pbrProgress.TabIndex = 13;
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Enabled = true;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // lblUpdate
            // 
            this.lblUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(12, 537);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(112, 13);
            this.lblUpdate.TabIndex = 15;
            this.lblUpdate.Text = "Checking for update...";
            // 
            // llbUpdate
            // 
            this.llbUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.llbUpdate.AutoSize = true;
            this.llbUpdate.Location = new System.Drawing.Point(12, 537);
            this.llbUpdate.Name = "llbUpdate";
            this.llbUpdate.Size = new System.Drawing.Size(114, 13);
            this.llbUpdate.TabIndex = 16;
            this.llbUpdate.TabStop = true;
            this.llbUpdate.Text = "New version available!";
            this.llbUpdate.Visible = false;
            this.llbUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbUpdate_LinkClicked);
            // 
            // gbxRandomOutput
            // 
            this.gbxRandomOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxRandomOutput.AutoSize = true;
            this.gbxRandomOutput.Controls.Add(this.cbxSfxOut);
            this.gbxRandomOutput.Controls.Add(this.cbxPartsOut);
            this.gbxRandomOutput.Controls.Add(this.cbxObjOut);
            this.gbxRandomOutput.Controls.Add(this.cbxMapOut);
            this.gbxRandomOutput.Controls.Add(this.cbxChrOut);
            this.gbxRandomOutput.Location = new System.Drawing.Point(690, 347);
            this.gbxRandomOutput.Name = "gbxRandomOutput";
            this.gbxRandomOutput.Size = new System.Drawing.Size(75, 147);
            this.gbxRandomOutput.TabIndex = 17;
            this.gbxRandomOutput.TabStop = false;
            this.gbxRandomOutput.Text = "Outputs";
            // 
            // cbxSfxOut
            // 
            this.cbxSfxOut.AutoSize = true;
            this.cbxSfxOut.Location = new System.Drawing.Point(6, 111);
            this.cbxSfxOut.Name = "cbxSfxOut";
            this.cbxSfxOut.Size = new System.Drawing.Size(39, 17);
            this.cbxSfxOut.TabIndex = 4;
            this.cbxSfxOut.Text = "sfx";
            this.cbxSfxOut.UseVisualStyleBackColor = true;
            // 
            // cbxPartsOut
            // 
            this.cbxPartsOut.AutoSize = true;
            this.cbxPartsOut.Checked = true;
            this.cbxPartsOut.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxPartsOut.Location = new System.Drawing.Point(6, 88);
            this.cbxPartsOut.Name = "cbxPartsOut";
            this.cbxPartsOut.Size = new System.Drawing.Size(49, 17);
            this.cbxPartsOut.TabIndex = 3;
            this.cbxPartsOut.Text = "parts";
            this.cbxPartsOut.UseVisualStyleBackColor = true;
            // 
            // cbxObjOut
            // 
            this.cbxObjOut.AutoSize = true;
            this.cbxObjOut.Checked = true;
            this.cbxObjOut.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxObjOut.Location = new System.Drawing.Point(6, 65);
            this.cbxObjOut.Name = "cbxObjOut";
            this.cbxObjOut.Size = new System.Drawing.Size(40, 17);
            this.cbxObjOut.TabIndex = 2;
            this.cbxObjOut.Text = "obj";
            this.cbxObjOut.UseVisualStyleBackColor = true;
            // 
            // cbxMapOut
            // 
            this.cbxMapOut.AutoSize = true;
            this.cbxMapOut.Checked = true;
            this.cbxMapOut.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxMapOut.Location = new System.Drawing.Point(6, 42);
            this.cbxMapOut.Name = "cbxMapOut";
            this.cbxMapOut.Size = new System.Drawing.Size(46, 17);
            this.cbxMapOut.TabIndex = 1;
            this.cbxMapOut.Text = "map";
            this.cbxMapOut.UseVisualStyleBackColor = true;
            // 
            // cbxChrOut
            // 
            this.cbxChrOut.AutoSize = true;
            this.cbxChrOut.Checked = true;
            this.cbxChrOut.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxChrOut.Location = new System.Drawing.Point(6, 19);
            this.cbxChrOut.Name = "cbxChrOut";
            this.cbxChrOut.Size = new System.Drawing.Size(41, 17);
            this.cbxChrOut.TabIndex = 0;
            this.cbxChrOut.Text = "chr";
            this.cbxChrOut.UseVisualStyleBackColor = true;
            // 
            // lblThreads
            // 
            this.lblThreads.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThreads.AutoSize = true;
            this.lblThreads.Location = new System.Drawing.Point(690, 497);
            this.lblThreads.Name = "lblThreads";
            this.lblThreads.Size = new System.Drawing.Size(46, 13);
            this.lblThreads.TabIndex = 18;
            this.lblThreads.Text = "Threads";
            // 
            // nudThreads
            // 
            this.nudThreads.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudThreads.Location = new System.Drawing.Point(690, 513);
            this.nudThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudThreads.Name = "nudThreads";
            this.nudThreads.Size = new System.Drawing.Size(75, 20);
            this.nudThreads.TabIndex = 19;
            this.nudThreads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCustomExplore
            // 
            this.btnCustomExplore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomExplore.Location = new System.Drawing.Point(690, 101);
            this.btnCustomExplore.Name = "btnCustomExplore";
            this.btnCustomExplore.Size = new System.Drawing.Size(75, 23);
            this.btnCustomExplore.TabIndex = 23;
            this.btnCustomExplore.Text = "Explore";
            this.btnCustomExplore.UseVisualStyleBackColor = true;
            this.btnCustomExplore.Click += new System.EventHandler(this.btnCustomExplore_Click);
            // 
            // btnCustomBrowse
            // 
            this.btnCustomBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomBrowse.Location = new System.Drawing.Point(609, 101);
            this.btnCustomBrowse.Name = "btnCustomBrowse";
            this.btnCustomBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnCustomBrowse.TabIndex = 22;
            this.btnCustomBrowse.Text = "Browse";
            this.btnCustomBrowse.UseVisualStyleBackColor = true;
            this.btnCustomBrowse.Click += new System.EventHandler(this.btnCustomBrowse_Click);
            // 
            // txtCustomDir
            // 
            this.txtCustomDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomDir.Location = new System.Drawing.Point(12, 103);
            this.txtCustomDir.Name = "txtCustomDir";
            this.txtCustomDir.Size = new System.Drawing.Size(591, 20);
            this.txtCustomDir.TabIndex = 21;
            this.txtCustomDir.Text = "Custom Textures";
            // 
            // lblCustomDir
            // 
            this.lblCustomDir.AutoSize = true;
            this.lblCustomDir.Location = new System.Drawing.Point(12, 87);
            this.lblCustomDir.Name = "lblCustomDir";
            this.lblCustomDir.Size = new System.Drawing.Size(131, 13);
            this.lblCustomDir.TabIndex = 20;
            this.lblCustomDir.Text = "Custom Textures Directory";
            // 
            // cbxCustomIn
            // 
            this.cbxCustomIn.AutoSize = true;
            this.cbxCustomIn.Location = new System.Drawing.Point(6, 134);
            this.cbxCustomIn.Name = "cbxCustomIn";
            this.cbxCustomIn.Size = new System.Drawing.Size(60, 17);
            this.cbxCustomIn.TabIndex = 24;
            this.cbxCustomIn.Text = "custom";
            this.cbxCustomIn.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 559);
            this.Controls.Add(this.btnCustomExplore);
            this.Controls.Add(this.btnCustomBrowse);
            this.Controls.Add(this.txtCustomDir);
            this.Controls.Add(this.lblCustomDir);
            this.Controls.Add(this.nudThreads);
            this.Controls.Add(this.lblThreads);
            this.Controls.Add(this.gbxRandomOutput);
            this.Controls.Add(this.llbUpdate);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.pbrProgress);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnUnpack);
            this.Controls.Add(this.btnRandomize);
            this.Controls.Add(this.btnUnpackExplore);
            this.Controls.Add(this.btnUnpackBrowse);
            this.Controls.Add(this.btnGameExplore);
            this.Controls.Add(this.btnGameBrowse);
            this.Controls.Add(this.gbxRandomInput);
            this.Controls.Add(this.txtUnpackDir);
            this.Controls.Add(this.lblUnpackDir);
            this.Controls.Add(this.txtGameDir);
            this.Controls.Add(this.lblGameDir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 597);
            this.Name = "FormMain";
            this.Text = "DSR Texture Randomizer <version>";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.gbxRandomInput.ResumeLayout(false);
            this.gbxRandomInput.PerformLayout();
            this.gbxRandomOutput.ResumeLayout(false);
            this.gbxRandomOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameDir;
        private System.Windows.Forms.TextBox txtGameDir;
        private System.Windows.Forms.TextBox txtUnpackDir;
        private System.Windows.Forms.Label lblUnpackDir;
        private System.Windows.Forms.GroupBox gbxRandomInput;
        private System.Windows.Forms.Button btnRandomize;
        private System.Windows.Forms.CheckBox cbxSfxIn;
        private System.Windows.Forms.CheckBox cbxPartsIn;
        private System.Windows.Forms.CheckBox cbxObjIn;
        private System.Windows.Forms.CheckBox cbxMapIn;
        private System.Windows.Forms.CheckBox cbxChrIn;
        private System.Windows.Forms.Button btnGameBrowse;
        private System.Windows.Forms.Button btnGameExplore;
        private System.Windows.Forms.Button btnUnpackBrowse;
        private System.Windows.Forms.Button btnUnpackExplore;
        private System.Windows.Forms.Button btnUnpack;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.ProgressBar pbrProgress;
        private System.Windows.Forms.FolderBrowserDialog fbdBrowse;
        private System.Windows.Forms.Timer tmrUpdate;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.LinkLabel llbUpdate;
        private System.Windows.Forms.GroupBox gbxRandomOutput;
        private System.Windows.Forms.CheckBox cbxSfxOut;
        private System.Windows.Forms.CheckBox cbxPartsOut;
        private System.Windows.Forms.CheckBox cbxObjOut;
        private System.Windows.Forms.CheckBox cbxMapOut;
        private System.Windows.Forms.CheckBox cbxChrOut;
        private System.Windows.Forms.Label lblThreads;
        private System.Windows.Forms.NumericUpDown nudThreads;
        private System.Windows.Forms.CheckBox cbxCustomIn;
        private System.Windows.Forms.Button btnCustomExplore;
        private System.Windows.Forms.Button btnCustomBrowse;
        private System.Windows.Forms.TextBox txtCustomDir;
        private System.Windows.Forms.Label lblCustomDir;
    }
}

