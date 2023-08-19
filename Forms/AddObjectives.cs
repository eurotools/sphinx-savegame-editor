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
    public partial class AddObjectives : Form
    {
        private Dictionary<uint, string> objectivesSection;

        //-------------------------------------------------------------------------------------------------------------------------------
        public AddObjectives()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void AddObjectives_Load(object sender, EventArgs e)
        {
            objectivesSection = HashCodes.Read_Sound_h(@"X:\Sphinx\Albert\Hashcodes.h", "HT_Objective");

            //Add items to list
            lstbxAvailableObjectives.BeginUpdate();
            lstbxAvailableObjectives.Items.AddRange(objectivesSection.Values.ToArray());
            lstbxAvailableObjectives.EndUpdate();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnAddObjective_Click(object sender, EventArgs e)
        {
            lstbxObjectivesToAdd.BeginUpdate();
            lstbxObjectivesToAdd.Items.AddRange(lstbxAvailableObjectives.SelectedItems.Cast<string>().ToArray());
            lstbxObjectivesToAdd.EndUpdate();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void BtnRemoveObjective_Click(object sender, EventArgs e)
        {
            lstbxObjectivesToAdd.BeginUpdate();
            while (lstbxObjectivesToAdd.SelectedItems.Count > 0)
            {
                lstbxObjectivesToAdd.Items.Remove(lstbxObjectivesToAdd.SelectedItems[0]);
            }
            lstbxObjectivesToAdd.EndUpdate();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void AddObjectives_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Ask for confirmation
            if (DialogResult == DialogResult.Cancel && lstbxObjectivesToAdd.Items.Count > 0)
            {
                DialogResult answer = MessageBox.Show("Are you sure you want to close without saving?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                //Update UI & Dictionary
                SvFile saveGameData = ((FrmMain)Application.OpenForms[nameof(FrmMain)]).fileData;
                foreach (string item in lstbxObjectivesToAdd.Items)
                {
                    uint hashcode = objectivesSection.FirstOrDefault(x => x.Value.Equals(item)).Key;
                    if (!saveGameData.Objectives.ContainsKey(hashcode))
                    {
                        saveGameData.Objectives.Add(hashcode, (uint)nudObjectiveValue.Value);
                    }
                }
                ((FrmMain)Application.OpenForms[nameof(FrmMain)]).UserControl_Objectives.PrintObjectives(saveGameData);
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
