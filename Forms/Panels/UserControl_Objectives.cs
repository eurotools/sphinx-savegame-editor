using SavegameEditor.Objects;
using SavegameEditor.Reader;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SavegameEditor.Forms.Panels
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class UserControl_Objectives : UserControl
    {
        internal SvFile fileData;

        //-------------------------------------------------------------------------------------------------------------------------------
        public UserControl_Objectives()
        {
            InitializeComponent();
        }

        //*===============================================================================================
        //* PRINT DATA METHODS
        //*===============================================================================================
        internal void PrintObjectives(SvFile savegameData)
        {
            fileData = savegameData;
            Dictionary<uint, string> HashTable = HashCodes.Read_Sound_h(Globals.HashCodesFilePath);

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
                bool containsHashCode = false;
                string hashcodeLabel = "**HASHCODE NOT FOUND**";
                if (HashTable.ContainsKey(objective.Key))
                {
                    hashcodeLabel = HashTable[objective.Key];
                }

                //Check value is a hashcode                
                string valueHashCode = objective.Value.ToString();
                if ((objective.Value & 0xFFFF0000) > 0)
                {
                    containsHashCode = true;
                    if (HashTable.ContainsKey(objective.Value))
                    {
                        valueHashCode = HashTable[objective.Value];
                    }
                }

                //Add new item
                ListViewItem itemData = new ListViewItem(new[] { hashcodeLabel, "0x" + objective.Key.ToString("X8"), valueHashCode, containsHashCode.ToString() })
                {
                    Tag = objective.Key
                };
                lvwObjectives.Items.Add(itemData);
            }
            lvwObjectives.EndUpdate();

            //Update label
            ((FrmMain)Application.OpenForms[nameof(FrmMain)]).StatusLabelObjectivesCount.Text = string.Format("Objectives Count: {0}", lvwObjectives.Items.Count);
        }

        //*===============================================================================================
        //* LIST VIEW CONTEXT MENU
        //*===============================================================================================
        private void MenuItem_AddObjectives_Click(object sender, EventArgs e)
        {
            if (fileData != null)
            {
                using (AddObjectives addObjForm = new AddObjectives())
                {
                    addObjForm.ShowDialog();
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_DeleteObjective_Click(object sender, EventArgs e)
        {
            if (lvwObjectives.SelectedItems.Count > 0)
            {
                lvwObjectives.BeginUpdate();
                foreach (ListViewItem itemToDelete in lvwObjectives.SelectedItems)
                {
                    fileData.Objectives.Remove((uint)itemToDelete.Tag);
                    itemToDelete.Remove();
                }
                lvwObjectives.EndUpdate();
                ((FrmMain)Application.OpenForms[nameof(FrmMain)]).StatusLabelObjectivesCount.Text = string.Format("Objectives Count: {0}", lvwObjectives.Items.Count);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_ModifyObjectives_Click(object sender, EventArgs e)
        {
            if (lvwObjectives.SelectedItems.Count > 0)
            {
                using (ObjectiveProperties objProps = new ObjectiveProperties(lvwObjectives.SelectedItems))
                {
                    objProps.ShowDialog();
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void LvwObjectives_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvwObjectives.SelectedItems.Count > 0)
            {
                using (ObjectiveProperties objPropsForm = new ObjectiveProperties(lvwObjectives.SelectedItems))
                {
                    objPropsForm.ShowDialog();
                }
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
