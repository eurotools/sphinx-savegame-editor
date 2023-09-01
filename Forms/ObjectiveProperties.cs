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
    public partial class ObjectiveProperties : Form
    {
        private bool dataModified;
        private readonly ListView.SelectedListViewItemCollection objectivesCollection;

        //-------------------------------------------------------------------------------------------------------------------------------
        public ObjectiveProperties(ListView.SelectedListViewItemCollection selectedObjectives)
        {
            InitializeComponent();
            objectivesCollection = selectedObjectives;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ObjectiveProperties_Load(object sender, EventArgs e)
        {
            //Read hashcodes
            Dictionary<uint, string> hashcodeLabels = HashCodes.Read_Sound_h(Globals.HashCodesFilePath, "HT_Objective", "HT_Text");
            cbxHashCode.Items.AddRange(hashcodeLabels.Values.ToArray());

            //Update Text
            if (objectivesCollection.Count > 1)
            {
                Text = "Set Multiple Objective Properties";
                txtObjective.Text = "<Multiple Objectives>";
            }
            else
            {
                txtObjective.Text = objectivesCollection[0].Text;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ObjectiveProperties_Shown(object sender, EventArgs e)
        {
            //Update Value
            if (int.TryParse(objectivesCollection[0].SubItems[2].Text, out int objValue))
            {
                radioButton1.Checked = true;
                nudObjectiveValue.Value = objValue;
            }
            else
            {
                radioButton2.Checked = true;
                cbxHashCode.SelectedItem = objectivesCollection[0].SubItems[2].Text;
            }

            dataModified = false;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void NudObjectiveValue_ValueChanged(object sender, EventArgs e)
        {
            dataModified = true;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void CbxHashCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataModified = true;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ObjectiveProperties_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Ask for confirmation
            if (DialogResult == DialogResult.Cancel && dataModified)
            {
                DialogResult answer = MessageBox.Show("Are you sure you want to close without saving?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                Dictionary<uint, string> HashTable = HashCodes.Read_Sound_h(Globals.HashCodesFilePath, "HT_Objective", "HT_Text_");

                //Update UI & Dictionary
                SvFile saveGameData = ((FrmMain)Application.OpenForms[nameof(FrmMain)]).fileData;
                foreach (ListViewItem objItem in objectivesCollection)
                {
                    if (radioButton1.Checked)
                    {
                        objItem.SubItems[2].Text = nudObjectiveValue.Value.ToString();
                        saveGameData.Objectives[(uint)objItem.Tag] = (uint)nudObjectiveValue.Value;
                        objItem.SubItems[3].Text = ContainsHashCode((uint)nudObjectiveValue.Value).ToString();
                    }
                    if (radioButton2.Checked && cbxHashCode.SelectedItem != null)
                    {
                        string selectedLabel = cbxHashCode.SelectedItem.ToString();
                        objItem.SubItems[2].Text = selectedLabel;

                        //Get HashCode Value
                        uint hashCode = HashTable.FirstOrDefault(x => x.Value.Equals(selectedLabel)).Key;
                        saveGameData.Objectives[(uint)objItem.Tag] = hashCode;
                        objItem.SubItems[3].Text = ContainsHashCode(hashCode).ToString();
                    }
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private bool ContainsHashCode(uint hashCodeValue)
        {
            bool containsHashCode = false;
            if ((hashCodeValue & 0xFFFF0000) > 0)
            {
                containsHashCode = true;
            }

            return containsHashCode;
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
