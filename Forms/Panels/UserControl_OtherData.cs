using SavegameEditor.Objects;
using SavegameEditor.Reader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SavegameEditor.Forms.Panels
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class UserControl_OtherData : UserControl
    {
        private SvFile fileData;

        //-------------------------------------------------------------------------------------------------------------------------------
        public UserControl_OtherData()
        {
            InitializeComponent();

            //Others Page
            Dictionary<uint, string> itemsSection = HashCodes.Read_Sound_h(Globals.HashCodesFilePath, "HT_Item", "HT_File");
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

            cbxProgMumBut4.BeginUpdate();
            cbxProgMumBut4.Items.AddRange(hashcodesArray);
            if (cbxProgMumBut4.Items.Count > 0)
            {
                cbxProgMumBut4.SelectedIndex = 0;
            }
            cbxProgMumBut4.EndUpdate();

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

            cbxProgSphinxBut4.BeginUpdate();
            cbxProgSphinxBut4.Items.AddRange(hashcodesArray);
            if (cbxProgSphinxBut4.Items.Count > 0)
            {
                cbxProgSphinxBut4.SelectedIndex = 0;
            }
            cbxProgSphinxBut4.EndUpdate();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal void PrintCameraSettings(SvFile savegameData)
        {
            fileData = savegameData;
            nudCamAngle.Value = (decimal)fileData.cameraSettings.camera_angle;
            nudCamElevation.Value = (decimal)fileData.cameraSettings.camera_elevation;
            nudCamDistance.Value = (decimal)fileData.cameraSettings.camera_distance;

            //Print data
            nudX.Value = (decimal)fileData.cameraSettings.camera_position.X;
            nudY.Value = (decimal)fileData.cameraSettings.camera_position.Y;
            nudZ.Value = (decimal)fileData.cameraSettings.camera_position.Z;
            nudW.Value = (decimal)fileData.cameraSettings.camera_position.W;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal void PrintProgrammableButtons(SvFile savegameData)
        {
            fileData = savegameData;
            Dictionary<uint, string> itemsSection = HashCodes.Read_Sound_h(Globals.HashCodesFilePath, "HT_Item", "HT_File");

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
            if (itemsSection.ContainsKey(fileData.mummy_prog_buttons[3]))
            {
                cbxProgMumBut4.SelectedItem = itemsSection[fileData.mummy_prog_buttons[3]];
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
            if (itemsSection.ContainsKey(fileData.sphinx_prog_buttons[3]))
            {
                cbxProgSphinxBut4.SelectedItem = itemsSection[fileData.sphinx_prog_buttons[3]];
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal void PrintInventoryNotes(SvFile savegameData)
        {
            fileData = savegameData;
            Dictionary<uint, string> fileSection = HashCodes.Read_Sound_h(Globals.HashCodesFilePath, "HT_Text");

            //Sphinx
            nudSphinxActiveNotes.Value = fileData.headerData.ActiveNotesSphinx;

            //Clear data
            if (lvwNotesSphinxInv.Items.Count > 0)
            {
                lvwNotesSphinxInv.Items.Clear();
            }

            //Print Data
            lvwNotesSphinxInv.BeginUpdate();
            foreach (KeyValuePair<uint, uint> sphinxNote in fileData.headerData.notes_sphinx)
            {
                ListViewItem itemData = new ListViewItem(new[] { fileSection[sphinxNote.Key], fileSection[sphinxNote.Value] })
                {
                    Tag = sphinxNote.Key
                };
                lvwNotesSphinxInv.Items.Add(itemData);
            }
            lvwNotesSphinxInv.EndUpdate();

            //Mummy - Notes
            nudMummyActiveNotes.Value = fileData.headerData.ActiveNotesMummy;

            //Clear data
            if (lvwNotesMummyInv.Items.Count > 0)
            {
                lvwNotesMummyInv.Items.Clear();
            }

            //Print Data
            lvwNotesMummyInv.BeginUpdate();
            foreach (KeyValuePair<uint, uint> mummyNote in fileData.headerData.notes_mummy)
            {
                ListViewItem itemData = new ListViewItem(new[] { fileSection[mummyNote.Key], fileSection[mummyNote.Value] })
                {
                    Tag = mummyNote.Key
                };
                lvwNotesMummyInv.Items.Add(itemData);
            }
            lvwNotesMummyInv.EndUpdate();
        }

        //*===============================================================================================
        //* SPHINX/MUMMY NOTES
        //*===============================================================================================
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

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_Notes_Add_Click(object sender, EventArgs e)
        {
            if (fileData != null)
            {
                using (AddNotes notesDiag = new AddNotes())
                {
                    if (notesDiag.ShowDialog() == DialogResult.OK)
                    {
                        //Get hashcodes
                        Dictionary<uint, string> fileSection = HashCodes.Read_Sound_h(Globals.HashCodesFilePath, "HT_Text_");
                        uint noteTitleHashcode = fileSection.FirstOrDefault(x => x.Value.Equals(notesDiag.cbxTitle)).Key;
                        uint noteDescHashcode = fileSection.FirstOrDefault(x => x.Value.Equals(notesDiag.cbxDescription)).Key;

                        //Add items to list
                        if (tabControlNotes.SelectedTab == tabPageMummy)
                        {
                            fileData.headerData.notes_mummy.Add(noteTitleHashcode, noteDescHashcode);
                            lvwNotesMummyInv.Items.Add(new ListViewItem(new[] { notesDiag.cbxTitle.SelectedItem.ToString(), notesDiag.cbxDescription.SelectedItem.ToString() }));
                        }
                        else
                        {
                            fileData.headerData.notes_sphinx.Add(noteTitleHashcode, noteDescHashcode);
                            lvwNotesSphinxInv.Items.Add(new ListViewItem(new[] { notesDiag.cbxTitle.SelectedItem.ToString(), notesDiag.cbxDescription.SelectedItem.ToString() }));
                        }
                    }
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_Notes_Remove_Click(object sender, EventArgs e)
        {
            if (fileData != null)
            {
                if (tabControlNotes.SelectedTab == tabPageMummy)
                {
                    foreach (ListViewItem listItem in lvwNotesMummyInv.SelectedItems)
                    {
                        fileData.headerData.notes_mummy.Remove((uint)listItem.Tag);
                        listItem.Remove();
                    }
                }
                else
                {
                    foreach (ListViewItem listItem in lvwNotesSphinxInv.SelectedItems)
                    {
                        fileData.headerData.notes_sphinx.Remove((uint)listItem.Tag);
                        listItem.Remove();
                    }
                }
            }
        }

        //*===============================================================================================
        //* CAMERA SETTINGS
        //*===============================================================================================
        private void NudCamAngle_MouseClick(object sender, MouseEventArgs e)
        {
            if (fileData != null)
            {
                fileData.cameraSettings.camera_angle = (float)nudCamAngle.Value;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void NudCamElevation_MouseClick(object sender, MouseEventArgs e)
        {
            if (fileData != null)
            {
                fileData.cameraSettings.camera_elevation = (float)nudCamElevation.Value;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void NudCamDistance_MouseClick(object sender, MouseEventArgs e)
        {
            if (fileData != null)
            {
                fileData.cameraSettings.camera_distance = (float)nudCamDistance.Value;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void NudX_MouseClick(object sender, MouseEventArgs e)
        {
            if (fileData != null)
            {
                fileData.cameraSettings.camera_position.X = (float)nudX.Value;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void NudY_MouseClick(object sender, MouseEventArgs e)
        {
            if (fileData != null)
            {
                fileData.cameraSettings.camera_position.Y = (float)nudY.Value;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void NudZ_MouseClick(object sender, MouseEventArgs e)
        {
            if (fileData != null)
            {
                fileData.cameraSettings.camera_position.Z = (float)nudZ.Value;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void NudW_MouseClick(object sender, MouseEventArgs e)
        {
            if (fileData != null)
            {
                fileData.cameraSettings.camera_position.W = (float)nudW.Value;
            }
        }

        //*===============================================================================================
        //* MUMMY PROGRAMMABLE BUTTONS
        //*===============================================================================================
        private void CbxProgMumBut1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (fileData != null)
            {
                Dictionary<uint, string> itemsSection = HashCodes.Read_Sound_h(Globals.HashCodesFilePath, "HT_Item", "HT_File");
                fileData.mummy_prog_buttons[0] = itemsSection.FirstOrDefault(x => x.Value.Equals(cbxProgMumBut1.SelectedItem)).Key;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void CbxProgMumBut2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (fileData != null)
            {
                Dictionary<uint, string> itemsSection = HashCodes.Read_Sound_h(Globals.HashCodesFilePath, "HT_Item", "HT_File");
                fileData.mummy_prog_buttons[1] = itemsSection.FirstOrDefault(x => x.Value.Equals(cbxProgMumBut2.SelectedItem)).Key;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void CbxProgMumBut3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (fileData != null)
            {
                Dictionary<uint, string> itemsSection = HashCodes.Read_Sound_h(Globals.HashCodesFilePath, "HT_Item", "HT_File");
                fileData.mummy_prog_buttons[2] = itemsSection.FirstOrDefault(x => x.Value.Equals(cbxProgMumBut3.SelectedItem)).Key;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void CbxProgMumBut4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (fileData != null)
            {
                Dictionary<uint, string> itemsSection = HashCodes.Read_Sound_h(Globals.HashCodesFilePath, "HT_Item", "HT_File");
                fileData.mummy_prog_buttons[3] = itemsSection.FirstOrDefault(x => x.Value.Equals(cbxProgMumBut4.SelectedItem)).Key;
            }
        }

        //*===============================================================================================
        //* SPHINX PROGRAMMABLE BUTTONS
        //*===============================================================================================
        private void CbxProgSphinxBut1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (fileData != null)
            {
                Dictionary<uint, string> itemsSection = HashCodes.Read_Sound_h(Globals.HashCodesFilePath, "HT_Item", "HT_File");
                fileData.sphinx_prog_buttons[0] = itemsSection.FirstOrDefault(x => x.Value.Equals(cbxProgSphinxBut1.SelectedItem)).Key;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void CbxProgSphinxBut2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (fileData != null)
            {
                Dictionary<uint, string> itemsSection = HashCodes.Read_Sound_h(Globals.HashCodesFilePath, "HT_Item", "HT_File");
                fileData.sphinx_prog_buttons[1] = itemsSection.FirstOrDefault(x => x.Value.Equals(cbxProgSphinxBut2.SelectedItem)).Key;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void CbxProgSphinxBut3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (fileData != null)
            {
                Dictionary<uint, string> itemsSection = HashCodes.Read_Sound_h(Globals.HashCodesFilePath, "HT_Item", "HT_File");
                fileData.sphinx_prog_buttons[2] = itemsSection.FirstOrDefault(x => x.Value.Equals(cbxProgSphinxBut3.SelectedItem)).Key;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void CbxProgSphinxBut4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (fileData != null)
            {
                Dictionary<uint, string> itemsSection = HashCodes.Read_Sound_h(Globals.HashCodesFilePath, "HT_Item", "HT_File");
                fileData.sphinx_prog_buttons[3] = itemsSection.FirstOrDefault(x => x.Value.Equals(cbxProgSphinxBut4.SelectedItem)).Key;
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
