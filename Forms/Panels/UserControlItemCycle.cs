using SavegameEditor.Objects;
using System.Windows.Forms;

namespace SavegameEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class UserControlItemCycle : UserControl
    {
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
                using (ItemProperties itemPropsForm = new ItemProperties(lvwCycle.SelectedItems, (int)Tag))
                {
                    itemPropsForm.ShowDialog();
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_AddItem_Click(object sender, System.EventArgs e)
        {

        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_RemoveItem_Click(object sender, System.EventArgs e)
        {
            //Get Inventory Data
            inventoryData = saveGameData.sphinx_inventory;
            int selectedInventory = ((FrmMain)Application.OpenForms[nameof(FrmMain)]).tabControlInventory.SelectedIndex;
            if (selectedInventory != 0)
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
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_ModifyItem_Click(object sender, System.EventArgs e)
        {
            if (lvwCycle.SelectedItems.Count > 0)
            {
                using (ItemProperties itemPropsForm = new ItemProperties(lvwCycle.SelectedItems, (int)Tag))
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
            int selectedInventory = ((FrmMain)Application.OpenForms[nameof(FrmMain)]).tabControlInventory.SelectedIndex;
            if (selectedInventory != 0)
            {
                inventoryData = saveGameData.mummy_inventory;
            }

            //Update property
            inventoryData.item_cycles[(int)Tag].cur_sel_item = (uint)nudSelectedItem.Value;
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
