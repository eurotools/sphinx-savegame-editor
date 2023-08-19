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
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void UserControl_OtherData_Load(object sender, EventArgs e)
        {
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
        internal void PrintCameraSettings(SvFile savegameData)
        {
            fileData = savegameData;
            txtAngle.Text = fileData.cameraSettings.camera_angle.ToString();
            txtElevation.Text = fileData.cameraSettings.camera_elevation.ToString();
            txtDistance.Text = fileData.cameraSettings.camera_distance.ToString();

            //Print data
            lvwCameraPos.Items.Clear();
            lvwCameraPos.BeginUpdate();
            lvwCameraPos.Items.Add(new ListViewItem(new[] { fileData.cameraSettings.camera_position.X.ToString(), fileData.cameraSettings.camera_position.Y.ToString(), fileData.cameraSettings.camera_position.Z.ToString(), fileData.cameraSettings.camera_position.W.ToString() }));
            lvwCameraPos.EndUpdate();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal void PrintProgrammableButtons(SvFile savegameData)
        {
            fileData = savegameData;
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
        internal void PrintInventoryNotes(SvFile savegameData)
        {
            fileData = savegameData;
            Dictionary<uint, string> fileSection = HashCodes.Read_Sound_h(@"X:\Sphinx\Albert\Hashcodes.h", "HT_Text");

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
                lvwNotesSphinxInv.Items.Add(new ListViewItem(new[] { fileSection[sphinxNote.Key], fileSection[sphinxNote.Value] }));
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
                lvwNotesMummyInv.Items.Add(new ListViewItem(new[] { fileSection[mummyNote.Key], fileSection[mummyNote.Value] }));
            }
            lvwNotesMummyInv.EndUpdate();
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
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
