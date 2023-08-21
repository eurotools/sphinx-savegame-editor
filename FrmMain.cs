using SavegameEditor.Forms;
using SavegameEditor.Objects;
using SavegameEditor.Reader;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SavegameEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class FrmMain : Form
    {
        internal SvFile fileData;

        //-------------------------------------------------------------------------------------------------------------------------------
        public FrmMain()
        {
            InitializeComponent();
        }

        //*===============================================================================================
        //* MAIN MENU - FILE
        //*===============================================================================================
        private void MenuItemOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenSaveFile(openFileDialog.FileName);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_Save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SvWriter_PC saveFile = new SvWriter_PC();
                saveFile.WriteFile(saveFileDialog.FileName, fileData);
                MessageBox.Show("File Saved Successfully!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //*===============================================================================================
        //* MAIN MENU - SETTINGS
        //*===============================================================================================
        private void MenuItemSettings_SetHashCodes_Click(object sender, EventArgs e)
        {
            if (openFileDialogHashCodes.ShowDialog() == DialogResult.OK)
            {
                Globals.HashCodesFilePath = openFileDialogHashCodes.FileName;
            }
        }

        //*===============================================================================================
        //* MAIN MENU - ABOUT
        //*===============================================================================================
        private void MenuItemHelp_About_Click(object sender, EventArgs e)
        {
            using (About frmAbout = new About())
            {
                frmAbout.ShowDialog();
            }
        }

        //*===============================================================================================
        //* FORM EVENTS
        //*===============================================================================================
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //Read hashcodes
            Dictionary<uint, string> fileSection = HashCodes.Read_Sound_h(Globals.HashCodesFilePath, "HT_File");
            cbxLevelHashCode.BeginUpdate();
            cbxLevelHashCode.Items.AddRange(fileSection.Values.ToArray());
            if (cbxLevelHashCode.Items.Count > 0)
            {
                cbxLevelHashCode.SelectedIndex = 0;
            }
            cbxLevelHashCode.EndUpdate();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void FrmMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void FrmMain_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            //Open only the first file
            if (files.Length > 0)
            {
                OpenSaveFile(files[0]);
            }
        }

        //*===============================================================================================
        //* HEADER DATA - CONTROL EVENTS
        //*===============================================================================================
        private void CbxLevelHashCode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Get Level hashcode
            Dictionary<uint, string> fileSection = HashCodes.Read_Sound_h(Globals.HashCodesFilePath, "HT_File");
            uint myKey = fileSection.FirstOrDefault(x => x.Value.Equals(cbxLevelHashCode.SelectedItem)).Key;

            //Update property
            if (fileData != null)
            {
                fileData.headerData.cur_level_hashcode = myKey;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void NumScarabs_MouseClick(object sender, MouseEventArgs e)
        {
            if (fileData != null)
            {
                fileData.headerData.scarabs = (ushort)numScarabs.Value;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void NumCrowns_MouseClick(object sender, MouseEventArgs e)
        {
            if (fileData != null)
            {
                fileData.headerData.crowns = (ushort)numCrowns.Value;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void NumLevelRestart_MouseClick(object sender, MouseEventArgs e)
        {
            if (fileData != null)
            {
                fileData.headerData.cur_level_restart_id = (uint)numLevelRestart.Value;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void NumLevelEntrance_MouseClick(object sender, MouseEventArgs e)
        {
            if (fileData != null)
            {
                fileData.headerData.cur_level_entrance_id = (int)numLevelEntrance.Value;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void NumHealthAnkhs_MouseClick(object sender, MouseEventArgs e)
        {
            if (fileData != null)
            {
                fileData.headerData.health_ankhs = (ushort)numHealthAnkhs.Value;
            }
        }

        //*===============================================================================================
        //* SECONDARY HEADER - FORM EVENTS
        //*===============================================================================================
        private void NudHealthThirds_MouseClick(object sender, MouseEventArgs e)
        {
            if (fileData != null)
            {
                fileData.health_thirds = (uint)nudHealthThirds.Value;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void NudTotalHealthThirds_MouseClick(object sender, MouseEventArgs e)
        {
            if (fileData != null)
            {
                fileData.total_health_thirds = (uint)nudTotalHealthThirds.Value;
            }
        }

        //*===============================================================================================
        //* PRINT DATA METHODS
        //*===============================================================================================
        internal void PrintHeader(SvFile savegameData)
        {
            Dictionary<uint, string> HashTable = HashCodes.Read_Sound_h(Globals.HashCodesFilePath, "HT_File");

            txtVersion.Text = "0x" + savegameData.headerData.version.ToString("X8");
            txtbTag.Text = savegameData.headerData.save_name_tag;
            numScarabs.Value = savegameData.headerData.scarabs;
            numCrowns.Value = savegameData.headerData.crowns;
            if (HashTable.ContainsKey(savegameData.headerData.cur_level_hashcode))
            {
                cbxLevelHashCode.SelectedItem = HashTable[savegameData.headerData.cur_level_hashcode];
            }
            numLevelRestart.Value = savegameData.headerData.cur_level_restart_id;
            numLevelEntrance.Value = savegameData.headerData.cur_level_entrance_id;
            numHealthAnkhs.Value = savegameData.headerData.health_ankhs;

            //Game time
            TimeSpan gameTime = TimeSpan.FromSeconds(savegameData.headerData.game_time_sec / 60);
            txtGameTime.Text = string.Format("{0:00}:{1:00}:{2:00}", gameTime.Hours, gameTime.Minutes, gameTime.Seconds);

            //Current Level Time
            TimeSpan levelTime = TimeSpan.FromSeconds(savegameData.headerData.cur_level_timer / 60);
            txtbLevelTime.Text = string.Format("{0:00}:{1:00}:{2:00}", levelTime.Hours, levelTime.Minutes, levelTime.Seconds);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void TxtGameTime_Validated(object sender, EventArgs e)
        {
            if (TimeSpan.TryParse(txtGameTime.Text, out TimeSpan gameTime))
            {
                uint convertedTime = (uint)(gameTime.TotalSeconds * 60);
                fileData.headerData.game_time_sec = convertedTime;
            }
            else
            {
                MessageBox.Show("Invalid format. Please enter a valid time in the format HH:MM:SS.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void TxtbLevelTime_Validated(object sender, EventArgs e)
        {
            if (TimeSpan.TryParse(txtbLevelTime.Text, out TimeSpan levelTime))
            {
                int convertedTime = (int)(levelTime.TotalSeconds * 60);
                fileData.headerData.cur_level_timer = convertedTime;
            }
            else
            {
                MessageBox.Show("Invalid format. Please enter a valid time in the format HH:MM:SS.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal void PrintSecondaryHeader(SvFile savegameData)
        {
            nudHealthThirds.Value = savegameData.health_thirds;
            nudTotalHealthThirds.Value = savegameData.total_health_thirds;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void OpenSaveFile(string filePath)
        {
            if (!string.IsNullOrEmpty(Globals.HashCodesFilePath) && File.Exists(Globals.HashCodesFilePath))
            {
                //Read file
                SvReader_PC fileReader = new SvReader_PC();
                try
                {
                    fileData = fileReader.ReadFile(filePath);
                    txtFilePath.Text = filePath;

                    //Show data
                    UserControl_Objectives.PrintObjectives(fileData);
                    PrintHeader(fileData);
                    PrintSecondaryHeader(fileData);
                    int sphinxItems = SphinxInventory.LoadInventory(fileData.sphinx_inventory);
                    StatusLabelSphinxItemsValue.Text = sphinxItems.ToString();
                    int mummyItems = MummyInventory.LoadInventory(fileData.mummy_inventory);
                    StatusLabelMummyItemsValue.Text = mummyItems.ToString();
                    UserControl_LevelTriggers.PrintLevelTriggers(fileData);
                    UserControl_OtherData.PrintCameraSettings(fileData);
                    UserControl_OtherData.PrintProgrammableButtons(fileData);
                    userControl_PlayerData1.PrintPlayerData(fileData);
                    UserControl_OtherData.PrintInventoryNotes(fileData);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please specify the path to \"hashcodes.h\" before opening the file. This dependency is required for proper functionality.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //*===============================================================================================
        //* TEST BUTTONS
        //*===============================================================================================
        private void Button_Test_Click(object sender, EventArgs e)
        {
            OpenSaveFile(@"C:\Users\Jordi Martinez\Saved Games\Sphinx__bin_PC\DATA0");
            SvWriter_PC saveFile = new SvWriter_PC();
            saveFile.WriteFile(@"C:\Users\Jordi Martinez\Desktop\DATA0", fileData);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnAutoLOad_Click(object sender, EventArgs e)
        {
            OpenSaveFile(@"C:\Users\Jordi Martinez\Saved Games\Sphinx__bin_PC\DATA0.OLD-2023.07.23-15.44.18");
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
