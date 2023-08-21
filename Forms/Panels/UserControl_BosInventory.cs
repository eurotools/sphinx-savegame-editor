using SavegameEditor.Objects;
using SavegameEditor.Reader;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SavegameEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class UserControl_BosInventory : UserControl
    {
        private SvInventory currentInventoryData;

        //-------------------------------------------------------------------------------------------------------------------------------
        public UserControl_BosInventory()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal int LoadInventory(SvInventory invData)
        {
            int totalItems = 0;
            currentInventoryData = invData;
            Dictionary<uint, string> HashTable = HashCodes.Read_Sound_h(Globals.HashCodesFilePath, "HT_Item", "HT_File");

            nudFilterInclude.Value = currentInventoryData.filter_include;
            nudFilterOptional.Value = currentInventoryData.filter_optional;
            nudFilterExclude.Value = currentInventoryData.filter_exclude;
            nudCurrentCycle.Value = currentInventoryData.current_cycle;

            //Clear tabs from previous checks
            if (tabInventoryCycles.TabPages.Count > 0)
            {
                tabInventoryCycles.TabPages.Clear();
            }

            //Add a tab for each cycle
            for (int i = 0; i < currentInventoryData.item_cycles.Count; i++)
            {
                tabInventoryCycles.TabPages.Add("Cycle" + i, string.Format("Cycle {0}", i + 1));

                //Add control
                UserControlItemCycle dataControl = new UserControlItemCycle
                {
                    Dock = DockStyle.Fill,
                    Tag = i
                };
                tabInventoryCycles.TabPages[i].Controls.Add(dataControl);

                //Add data to contorl
                dataControl.nudSelectedItem.Value = currentInventoryData.item_cycles[i].cur_sel_item;
                dataControl.lvwCycle.BeginUpdate();
                foreach (SvInvItem itemData in currentInventoryData.item_cycles[i].items.Values)
                {
                    //Get Hashcode Label
                    string hashcodeLabel = "**HASHCODE NOT FOUND**";
                    if (HashTable.ContainsKey(itemData.hashcode))
                    {
                        hashcodeLabel = HashTable[itemData.hashcode];
                    }

                    //Add new item
                    ListViewItem listItem = new ListViewItem(new[] { hashcodeLabel, "0x" + itemData.hashcode.ToString("X8"), itemData.count_cur.ToString(), itemData.count_max.ToString(), itemData.flags.ToString() })
                    {
                        Tag = itemData.hashcode
                    };
                    dataControl.lvwCycle.Items.Add(listItem);
                    totalItems++;
                }
                dataControl.lvwCycle.EndUpdate();
            }

            return totalItems;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void NudFilterInclude_Click(object sender, System.EventArgs e)
        {
            currentInventoryData.filter_include = (uint)nudFilterInclude.Value;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void NudFilterOptional_Click(object sender, System.EventArgs e)
        {
            currentInventoryData.filter_optional = (uint)nudFilterOptional.Value;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void NudFilterExclude_Click(object sender, System.EventArgs e)
        {
            currentInventoryData.filter_exclude = (uint)nudFilterExclude.Value;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void NudCurrentCycle_Click(object sender, System.EventArgs e)
        {
            currentInventoryData.current_cycle = (uint)nudCurrentCycle.Value;
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
