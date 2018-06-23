
--| DSR Texture Randomizer 1.0
--| https://www.nexusmods.com/darksoulsremastered/mods/67
--| https://github.com/JKAnderson/DSR-Texture-Randomizer

Extracts and shuffles the game's textures, and allows you to add your own to the pool. Running as Administrator is recommended.
Requires .NET 4.7.2: https://www.microsoft.com/net/download/thank-you/net472
Windows 10 users should already have this.
and Visual C++ 2015: https://www.microsoft.com/en-us/download/details.aspx?id=48145
Make sure to get the x64 installer.


--| Instructions

First, download the tool and extract the entire folder wherever you like. After launching it, make sure the Game Directory field points to the folder where your game is installed (the folder that contains DarkSoulsRemastered.exe.)
Next, click the Unpack button to extract all game textures (if you've already unpacked them with TPUP you can just change the folder to point to those instead.)
Finally, pick which types of textures you want to include in the pool and which textures you want to be replaced, then click the Randomize button. Be warned: this will probably take a long time. By default one or two cores are left free since otherwise it can make your computer basically unusable until it finishes, but if you want to speed up the process you can increase the number of threads.

Backups are created automatically; to revert the game to its unmodified state, click the Restore button.


--| Credits

Costura.Fody by Simon Cropp, Cameron MacFarland
https://github.com/Fody/Costura

DirectXTex by Microsoft Corp
https://github.com/Microsoft/DirectXTex

Octokit by GitHub
https://github.com/octokit/octokit.net

Semver by Max Hauser
https://github.com/maxhauser/semver

TeximpNet by Nicholas Woodfield
https://bitbucket.org/Starnick/teximpnet
