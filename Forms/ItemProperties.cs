using SavegameEditor.Objects;
using System;
using System.Windows.Forms;

namespace SavegameEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class ItemProperties : Form
    {
        private bool dataModified;
        private readonly int SelectedCycle;
        private readonly ListView.SelectedListViewItemCollection objectivesCollection;
        private readonly SvFile saveGameData = ((FrmMain)Application.OpenForms[nameof(FrmMain)]).fileData;
        private SvInventory inventoryData;
        private bool UserClick = true;

        //-------------------------------------------------------------------------------------------------------------------------------
        public ItemProperties(ListView.SelectedListViewItemCollection selectedObjectives, int cycleSelected)
        {
            InitializeComponent();
            objectivesCollection = selectedObjectives;
            SelectedCycle = cycleSelected;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ItemProperties_Load(object sender, EventArgs e)
        {
            //Get Inventory Data
            inventoryData = saveGameData.sphinx_inventory;
            int selectedInventory = ((FrmMain)Application.OpenForms[nameof(FrmMain)]).tabControlInventory.SelectedIndex;
            if (selectedInventory != 0)
            {
                inventoryData = saveGameData.mummy_inventory;
            }

            //Set item data
            SvInvItem itemData = inventoryData.item_cycles[SelectedCycle].items[(uint)objectivesCollection[0].Tag];
            if (objectivesCollection.Count > 1)
            {
                Text = "Set Multiple Item Properties";
                txtHashCodeLabel.Text = "<Multiple Items>";
                foreach (ListViewItem objItem in objectivesCollection)
                {
                    itemData = saveGameData.sphinx_inventory.item_cycles[SelectedCycle].items[(uint)objItem.Tag];
                    SetFlags(itemData.flags, CheckState.Indeterminate);
                }
            }
            else
            {
                txtHashCodeLabel.Text = objectivesCollection[0].Text;
                SetFlags(itemData.flags, CheckState.Checked);
            }

            //Min and max
            nudCurrentAmount.Value = itemData.count_cur;
            nudMaxAmount.Value = itemData.count_max;
            dataModified = false;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ItemProperties_FormClosing(object sender, FormClosingEventArgs e)
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
                //Update UI & Dictionary
                foreach (ListViewItem objItem in objectivesCollection)
                {
                    SvInvItem itemData = inventoryData.item_cycles[SelectedCycle].items[(uint)objItem.Tag];
                    uint flags = GetFlags(itemData.flags);

                    //Update UI
                    objItem.SubItems[2].Text = nudCurrentAmount.Value.ToString();
                    objItem.SubItems[3].Text = nudMaxAmount.Value.ToString();
                    objItem.SubItems[4].Text = flags.ToString();

                    //Update object
                    itemData.count_cur = (int)nudCurrentAmount.Value;
                    itemData.count_max = (int)nudMaxAmount.Value;
                    itemData.flags = flags;
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void NudCurrentAmount_ValueChanged(object sender, EventArgs e)
        {
            dataModified = true;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void NudMaxAmount_ValueChanged(object sender, EventArgs e)
        {
            dataModified = true;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void CheckListbox_Flags_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (UserClick)
            {
                switch (e.CurrentValue)
                {
                    case CheckState.Checked:
                        e.NewValue = CheckState.Indeterminate;
                        break;
                    case CheckState.Indeterminate:
                        e.NewValue = CheckState.Unchecked;
                        break;
                    case CheckState.Unchecked:
                        e.NewValue = CheckState.Checked;
                        break;
                }
                dataModified = true;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void SetFlags(uint flags, CheckState flagStatus)
        {
            UserClick = !UserClick;
            for (int i = 0; i < 32; i++)
            {
                if (Convert.ToBoolean((flags >> i) & 1))
                {
                    CheckListbox_Flags.SetItemCheckState(i, flagStatus);
                }
            }
            UserClick = !UserClick;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private uint GetFlags(uint CheckedFlagsResult)
        {
            for (int i = 0; i < 32; i++)
            {
                if (CheckListbox_Flags.GetItemCheckState(i) == CheckState.Checked)
                {
                    CheckedFlagsResult |= ((uint)1 << i);
                }
                if (CheckListbox_Flags.GetItemCheckState(i) == CheckState.Unchecked)
                {
                    CheckedFlagsResult &= ~((uint)1 << i);
                }
            }

            return CheckedFlagsResult;
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
