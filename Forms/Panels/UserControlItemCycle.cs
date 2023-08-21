using SavegameEditor.Objects;
using System.Windows.Forms;

namespace SavegameEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class UserControlItemCycle : UserControl
    {
        private readonly FrmMain mainForm = (FrmMain)Application.OpenForms[nameof(FrmMain)];
        private readonly SvFile saveGameData = ((FrmMain)Application.OpenForms[nameof(FrmMain)]).fileData;
        private SvInventory inventoryData;

        //-------------------------------------------------------------------------------------------------------------------------------
        public UserControlItemCycle()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void LvwCycle_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvwCycle.SelectedItems.Count > 0)
            {
                using (ItemProperties itemPropsForm = new ItemProperties(lvwCycle, (int)Tag))
                {
                    itemPropsForm.ShowDialog();
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_AddItem_Click(object sender, System.EventArgs e)
        {
            if (saveGameData != null)
            {
                using (ItemProperties itemPropsForm = new ItemProperties(lvwCycle, (int)Tag, true))
                {
                    itemPropsForm.ShowDialog();

                    //Update Label
                    RecountInventoryItems();
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_RemoveItem_Click(object sender, System.EventArgs e)
        {
            //Get Inventory Data
            inventoryData = saveGameData.sphinx_inventory;
            if (mainForm.tabControlInventory.SelectedIndex != 0)
            {
                inventoryData = saveGameData.mummy_inventory;
            }

            //Remove all selected items
            lvwCycle.BeginUpdate();
            foreach (ListViewItem itemData in lvwCycle.SelectedItems)
            {
                inventoryData.item_cycles[(int)Tag].items.Remove((uint)itemData.Tag);
                itemData.Remove();
            }
            lvwCycle.EndUpdate();

            //Update Label
            RecountInventoryItems();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_ModifyItem_Click(object sender, System.EventArgs e)
        {
            if (lvwCycle.SelectedItems.Count > 0)
            {
                using (ItemProperties itemPropsForm = new ItemProperties(lvwCycle, (int)Tag))
                {
                    itemPropsForm.ShowDialog();
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void NudSelectedItem_Click(object sender, System.EventArgs e)
        {
            //Get Inventory Data
            inventoryData = saveGameData.sphinx_inventory;
            if (mainForm.tabControlInventory.SelectedIndex != 0)
            {
                inventoryData = saveGameData.mummy_inventory;
            }

            //Update property
            inventoryData.item_cycles[(int)Tag].cur_sel_item = (uint)nudSelectedItem.Value;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void RecountInventoryItems()
        {
            //Get label to modify
            inventoryData = saveGameData.sphinx_inventory;
            ToolStripStatusLabel statusLabel = mainForm.StatusLabelSphinxItemsValue;
            if (mainForm.tabControlInventory.SelectedIndex != 0)
            {
                inventoryData = saveGameData.mummy_inventory;
                statusLabel = mainForm.StatusLabelMummyItemsValue;
            }

            //Recount items
            int totalItems = 0;
            foreach (SvItemCycle cycleItems in inventoryData.item_cycles)
            {
                totalItems += cycleItems.items.Count;
            }
            statusLabel.Text = totalItems.ToString();
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
