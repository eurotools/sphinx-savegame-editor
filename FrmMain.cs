using SavegameEditor.Objects;
using SavegameEditor.Reader;
using System;
using System.Collections.Generic;
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
        //* FORM EVENTS
        //*===============================================================================================
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //Read hashcodes
            Dictionary<uint, string> fileSection = HashCodes.Read_Sound_h(@"X:\Sphinx\Albert\Hashcodes.h", "HT_File");
            cbxLevelHashCode.BeginUpdate();
            cbxLevelHashCode.Items.AddRange(fileSection.Values.ToArray());
            if (cbxLevelHashCode.Items.Count > 0)
            {
                cbxLevelHashCode.SelectedIndex = 0;
            }
            cbxLevelHashCode.EndUpdate();

            //Others Page
            Dictionary<uint, string> itemsSection = HashCodes.Read_Sound_h(@"X:\Sphinx\Albert\Hashcodes.h", "HT_Item", "HT_File");
            string[] hashcodesArray = itemsSection.Values.ToArray();
            cbxProgMumBut1.BeginUpdate();
            cbxProgMumBut1.Items.AddRange(hashcodesArray);
            if (cbxProgMumBut1.Items.Count > 0)
            {
                cbxProgMumBut1.SelectedIndex = 0;
            }
            cbxProgMumBut1.EndUpdate();

            cbxProgMumBut2.BeginUpdate();
            cbxProgMumBut2.Items.AddRange(hashcodesArray);
            if (cbxProgMumBut2.Items.Count > 0)
            {
                cbxProgMumBut2.SelectedIndex = 0;
            }
            cbxProgMumBut2.EndUpdate();

            cbxProgMumBut3.BeginUpdate();
            cbxProgMumBut3.Items.AddRange(hashcodesArray);
            if (cbxProgMumBut3.Items.Count > 0)
            {
                cbxProgMumBut3.SelectedIndex = 0;
            }
            cbxProgMumBut3.EndUpdate();

            cbxProgSphinxBut1.BeginUpdate();
            cbxProgSphinxBut1.Items.AddRange(hashcodesArray);
            if (cbxProgSphinxBut1.Items.Count > 0)
            {
                cbxProgSphinxBut1.SelectedIndex = 0;
            }
            cbxProgSphinxBut1.EndUpdate();

            cbxProgSphinxBut2.BeginUpdate();
            cbxProgSphinxBut2.Items.AddRange(hashcodesArray);
            if (cbxProgSphinxBut2.Items.Count > 0)
            {
                cbxProgSphinxBut2.SelectedIndex = 0;
            }
            cbxProgSphinxBut2.EndUpdate();

            cbxProgSphinxBut3.BeginUpdate();
            cbxProgSphinxBut3.Items.AddRange(hashcodesArray);
            if (cbxProgSphinxBut3.Items.Count > 0)
            {
                cbxProgSphinxBut3.SelectedIndex = 0;
            }
            cbxProgSphinxBut3.EndUpdate();
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
            Dictionary<uint, string> fileSection = HashCodes.Read_Sound_h(@"X:\Sphinx\Albert\Hashcodes.h", "HT_File");
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

        //-------------------------------------------------------------------------------------------------------------------------------
        private void NudSphinxActiveNotes_MouseClick(object sender, MouseEventArgs e)
        {
            if (fileData != null)
            {
                fileData.headerData.ActiveNotesSphinx = (ushort)nudSphinxActiveNotes.Value;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void NudMummyActiveNotes_MouseClick(object sender, MouseEventArgs e)
        {
            if (fileData != null)
            {
                fileData.headerData.ActiveNotesMummy = (ushort)nudMummyActiveNotes.Value;
            }
        }

        //*===============================================================================================
        //* LIST VIEW OBJECTVIES
        //*===============================================================================================
        private void LvwObjectives_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvwObjectives.Items.Count > 0)
            {
                using (ObjectiveProperties objPropsForm = new ObjectiveProperties(lvwObjectives.SelectedItems))
                {
                    objPropsForm.ShowDialog();
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_AddObjective_Click(object sender, EventArgs e)
        {
            using (AddObjectives addObjForm = new AddObjectives())
            {
                addObjForm.ShowDialog();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_DeleteObjective_Click(object sender, EventArgs e)
        {
            lvwObjectives.BeginUpdate();
            foreach (ListViewItem itemToDelete in lvwObjectives.SelectedItems)
            {
                fileData.Objectives.Remove((uint)itemToDelete.Tag);
                itemToDelete.Remove();
            }
            lvwObjectives.EndUpdate();
            StatusLabelObjectivesCount.Text = string.Format("Objectives Count: {0}", lvwObjectives.Items.Count);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_ModifyObjectives_Click(object sender, EventArgs e)
        {
            using (ObjectiveProperties objProps = new ObjectiveProperties(lvwObjectives.SelectedItems))
            {
                objProps.ShowDialog();
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
        internal void PrintObjectives(SvFile savegameData)
        {
            Dictionary<uint, string> HashTable = HashCodes.Read_Sound_h(@"X:\Sphinx\Albert\Hashcodes.h");

            lvwObjectives.BeginUpdate();

            //Clear control if required
            if (lvwObjectives.Items.Count > 0)
            {
                lvwObjectives.Items.Clear();
            }

            //Add data
            foreach (KeyValuePair<uint, uint> objective in savegameData.Objectives)
            {
                //Get Hashcode Label
                string hashcodeLabel = "**HASHCODE NOT FOUND**";
                if (HashTable.ContainsKey(objective.Key))
                {
                    hashcodeLabel = HashTable[objective.Key];
                }

                //Check value is a hashcode
                string valueHashCode = objective.Value.ToString();
                if ((objective.Value & 0xFFFF0000) > 0)
                {
                    valueHashCode = "**HASHCODE NOT FOUND**";
                    if (HashTable.ContainsKey(objective.Value))
                    {
                        valueHashCode = HashTable[objective.Value];
                    }
                }

                //Add new item
                ListViewItem itemData = new ListViewItem(new[] { hashcodeLabel, "0x" + objective.Key.ToString("X8"), valueHashCode })
                {
                    Tag = objective.Key
                };
                lvwObjectives.Items.Add(itemData);
            }
            lvwObjectives.EndUpdate();

            //Update label
            StatusLabelObjectivesCount.Text = string.Format("Objectives Count: {0}", lvwObjectives.Items.Count);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal void PrintHeader(SvFile savegameData)
        {
            Dictionary<uint, string> HashTable = HashCodes.Read_Sound_h(@"X:\Sphinx\Albert\Hashcodes.h", "HT_File");

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
        internal void PrintSecondaryHeader(SvFile savegameData)
        {
            nudHealthThirds.Value = savegameData.health_thirds;
            nudTotalHealthThirds.Value = savegameData.total_health_thirds;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal void PrintLevelTriggers(SvFile savegameData)
        {
            lvwCurrentLevelTriggers.BeginUpdate();
            foreach (var triggerData in savegameData.cur_level_triggers)
            {
                lvwCurrentLevelTriggers.Items.Add(new ListViewItem(new[] { triggerData.trig_type.ToString(), triggerData.trig_subtype.ToString(), triggerData.saved_state_value.ToString(), triggerData.vector_xyz.X.ToString(), triggerData.vector_xyz.Y.ToString(), triggerData.vector_xyz.Z.ToString() }));
            }
            lvwCurrentLevelTriggers.EndUpdate();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal void PrintCharactersData(SvFile saveGameData)
        {
            cbxPlayerCharacter.SelectedIndex = (int)saveGameData.player_character_idx;
            chkMummyCopy1.Checked = saveGameData.triple_mummy_copies_are_active[0] == 1;
            chkMummyCopy2.Checked = saveGameData.triple_mummy_copies_are_active[1] == 1;

            //Print position
            lvwTripMummyPos.BeginUpdate();
            foreach (SvVectorXYZW mummyPos in saveGameData.triple_mummy_copies_postition)
            {
                lvwTripMummyPos.Items.Add(new ListViewItem(new[] { mummyPos.X.ToString(), mummyPos.Y.ToString(), mummyPos.Z.ToString(), mummyPos.W.ToString() }));
            }
            lvwTripMummyPos.EndUpdate();

            //Print position
            lvwTripMummyRot.BeginUpdate();
            foreach (SvVectorXYZW mummyRot in saveGameData.triple_mummy_copies_postition)
            {
                lvwTripMummyRot.Items.Add(new ListViewItem(new[] { mummyRot.X.ToString(), mummyRot.Y.ToString(), mummyRot.Z.ToString(), mummyRot.W.ToString() }));
            }
            lvwTripMummyRot.EndUpdate();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal void PrintCameraSettings(SvFile fileData)
        {
            txtAngle.Text = fileData.cameraSettings.camera_angle.ToString();
            txtElevation.Text = fileData.cameraSettings.camera_elevation.ToString();
            txtDistance.Text = fileData.cameraSettings.camera_distance.ToString();
            lvwCameraPos.Items.Add(new ListViewItem(new[] { fileData.cameraSettings.camera_position.X.ToString(), fileData.cameraSettings.camera_position.Y.ToString(), fileData.cameraSettings.camera_position.Z.ToString(), fileData.cameraSettings.camera_position.W.ToString() }));
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal void PrintProgrammableButtons(SvFile fileData)
        {
            Dictionary<uint, string> itemsSection = HashCodes.Read_Sound_h(@"X:\Sphinx\Albert\Hashcodes.h", "HT_Item", "HT_File");

            //Mummy Buttons
            if (itemsSection.ContainsKey(fileData.mummy_prog_buttons[0]))
            {
                cbxProgMumBut1.SelectedItem = itemsSection[fileData.mummy_prog_buttons[0]];
            }
            if (itemsSection.ContainsKey(fileData.mummy_prog_buttons[1]))
            {
                cbxProgMumBut2.SelectedItem = itemsSection[fileData.mummy_prog_buttons[1]];
            }
            if (itemsSection.ContainsKey(fileData.mummy_prog_buttons[2]))
            {
                cbxProgMumBut3.SelectedItem = itemsSection[fileData.mummy_prog_buttons[2]];
            }

            //Sphinx buttons
            if (itemsSection.ContainsKey(fileData.sphinx_prog_buttons[0]))
            {
                cbxProgSphinxBut1.SelectedItem = itemsSection[fileData.sphinx_prog_buttons[0]];
            }
            if (itemsSection.ContainsKey(fileData.sphinx_prog_buttons[1]))
            {
                cbxProgSphinxBut2.SelectedItem = itemsSection[fileData.sphinx_prog_buttons[1]];
            }
            if (itemsSection.ContainsKey(fileData.sphinx_prog_buttons[2]))
            {
                cbxProgSphinxBut3.SelectedItem = itemsSection[fileData.sphinx_prog_buttons[2]];
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void PrintPlayerData(SvFile fileData)
        {
            //Player data properties
            cbxPlayerCharacter.SelectedIndex = (int)fileData.player_character_idx;
            chkMummyCopy1.Checked = fileData.triple_mummy_copies_are_active[0] == 1;
            chkMummyCopy2.Checked = fileData.triple_mummy_copies_are_active[1] == 1;

            //Print position
            foreach(SvVectorXYZW playerPos in fileData.triple_mummy_copies_postition)
            {
                lvwTripMummyPos.Items.Add(new ListViewItem(new[] { playerPos.X.ToString(), playerPos.Y.ToString(), playerPos.Z.ToString(), playerPos.W.ToString() }));
            }

            //Print rotation
            foreach (SvVectorXYZW playerRotation in fileData.triple_mummy_copies_rotation)
            {
                lvwTripMummyRot.Items.Add(new ListViewItem(new[] { playerRotation.X.ToString(), playerRotation.Y.ToString(), playerRotation.Z.ToString(), playerRotation.W.ToString() }));
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void PrintInventoryNotes(SvFile fileData)
        {
            Dictionary<uint, string> fileSection = HashCodes.Read_Sound_h(@"X:\Sphinx\Albert\Hashcodes.h", "HT_Text");

            //Sphinx
            nudSphinxActiveNotes.Value = fileData.headerData.ActiveNotesSphinx;
            foreach(KeyValuePair<uint, uint> sphinxNote in fileData.headerData.notes_sphinx)
            {
                lvwNotesSphinxInv.Items.Add(new ListViewItem(new[] { fileSection[sphinxNote.Key], fileSection[sphinxNote.Value] }));
            }

            //Mummy
            nudMummyActiveNotes.Value = fileData.headerData.ActiveNotesMummy;
            foreach (KeyValuePair<uint, uint> mummyNote in fileData.headerData.notes_mummy)
            {
                lvwNotesMummyInv.Items.Add(new ListViewItem(new[] { fileSection[mummyNote.Key], fileSection[mummyNote.Value] }));
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void OpenSaveFile(string filePath)
        {
            //Read file
            SvReader_PC fileReader = new SvReader_PC();
            try
            {
                fileData = fileReader.ReadFile(filePath);
                txtFilePath.Text = filePath;

                //Show data
                PrintObjectives(fileData);
                PrintHeader(fileData);
                PrintSecondaryHeader(fileData);
                SphinxInventory.LoadInventory(fileData.sphinx_inventory);
                MummyInventory.LoadInventory(fileData.mummy_inventory);
                PrintLevelTriggers(fileData);
                PrintCharactersData(fileData);
                PrintCameraSettings(fileData);
                PrintProgrammableButtons(fileData);
                PrintPlayerData(fileData);
                PrintInventoryNotes(fileData);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            OpenSaveFile(@"C:\Users\Jordi Martinez\Saved Games\Sphinx__bin_PC\DATA0");
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
