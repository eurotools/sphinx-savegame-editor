using SavegameEditor.Objects;
using System.Linq;
using System.Windows.Forms;

namespace SavegameEditor.Forms
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class TriggerProperties : Form
    {
        private readonly SvFile saveGameData = ((FrmMain)Application.OpenForms[nameof(FrmMain)]).fileData;
        private readonly bool NewItemMode = false;
        private readonly ListView itemsListView;
        private bool dataModified;
        private SvTrigger triggerData;

        //-------------------------------------------------------------------------------------------------------------------------------
        public TriggerProperties(ListView selectedObjectives, bool AddNewItem = false)
        {
            InitializeComponent();
            itemsListView = selectedObjectives;
            NewItemMode = AddNewItem;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void TriggerProperties_Load(object sender, System.EventArgs e)
        {
            if (NewItemMode)
            {
                triggerData = new SvTrigger();
            }
            else
            {
                triggerData = saveGameData.cur_level_triggers[(uint)itemsListView.SelectedItems[0].Tag];
            }

            //Set values to control
            nudTrigType.Value = triggerData.trig_type;
            nudTrigSubtype.Value = triggerData.trig_subtype;
            nudTrigStateValue.Value = triggerData.saved_state_value;
            nudTrigX.Value = (decimal)triggerData.vector_xyz.X;
            nudTrigY.Value = (decimal)triggerData.vector_xyz.Y;
            nudTrigZ.Value = (decimal)triggerData.vector_xyz.Z;
            dataModified = false;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void TriggerProperties_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Ask for confirmation
            if (DialogResult == DialogResult.Cancel && (dataModified || NewItemMode))
            {
                DialogResult answer = MessageBox.Show("Are you sure you want to close without saving?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                if (NewItemMode)
                {
                    //Set item data
                    triggerData.saved_state_value = (uint)nudTrigStateValue.Value;
                    triggerData.trig_subtype = (uint)nudTrigSubtype.Value;
                    triggerData.trig_type = (uint)nudTrigType.Value;
                    triggerData.vector_xyz.X = (float)nudTrigX.Value;
                    triggerData.vector_xyz.Y = (float)nudTrigY.Value;
                    triggerData.vector_xyz.Z = (float)nudTrigZ.Value;

                    //Add item to dictionary
                    uint[] availableKeys = saveGameData.cur_level_triggers.Keys.ToArray();
                    uint triggerKey = Globals.GetMaxValueArray(availableKeys) + 1;
                    saveGameData.cur_level_triggers.Add(triggerKey, triggerData);

                    //Add item to list
                    ListViewItem listItem = new ListViewItem(new[] { triggerData.trig_type.ToString(), triggerData.trig_subtype.ToString(), triggerData.saved_state_value.ToString(), triggerData.vector_xyz.X.ToString("0.0######"), triggerData.vector_xyz.Y.ToString("0.0######"), triggerData.vector_xyz.Z.ToString("0.0######") })
                    {
                        Tag = triggerKey
                    };
                    itemsListView.Items.Add(listItem);
                }
                else
                {
                    foreach (ListViewItem objItem in itemsListView.SelectedItems)
                    {
                        //Update object
                        triggerData = saveGameData.cur_level_triggers[(uint)objItem.Tag];
                        triggerData.trig_type = (uint)nudTrigType.Value;
                        triggerData.trig_subtype = (uint)nudTrigSubtype.Value;
                        triggerData.saved_state_value = (uint)nudTrigStateValue.Value;
                        triggerData.vector_xyz.X = (float)nudTrigX.Value;
                        triggerData.vector_xyz.Y = (float)nudTrigY.Value;
                        triggerData.vector_xyz.Z = (float)nudTrigZ.Value;

                        //Update UI
                        objItem.SubItems[0].Text = nudTrigType.Value.ToString();
                        objItem.SubItems[1].Text = nudTrigSubtype.Value.ToString();
                        objItem.SubItems[2].Text = nudTrigStateValue.Value.ToString();
                        objItem.SubItems[3].Text = nudTrigX.Value.ToString();
                        objItem.SubItems[4].Text = nudTrigY.Value.ToString();
                        objItem.SubItems[5].Text = nudTrigZ.Value.ToString();
                    }
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void NudTrigType_ValueChanged(object sender, System.EventArgs e)
        {
            dataModified = true;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void NudTrigSubtype_ValueChanged(object sender, System.EventArgs e)
        {
            dataModified = true;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void NudTrigStateValue_ValueChanged(object sender, System.EventArgs e)
        {
            dataModified = true;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void NudTrigX_ValueChanged(object sender, System.EventArgs e)
        {
            dataModified = true;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void NudTrigY_ValueChanged(object sender, System.EventArgs e)
        {
            dataModified = true;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void NudTrigZ_ValueChanged(object sender, System.EventArgs e)
        {
            dataModified = true;
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
