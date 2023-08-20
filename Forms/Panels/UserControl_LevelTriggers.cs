using SavegameEditor.Objects;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SavegameEditor.Forms.Panels
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class UserControl_LevelTriggers : UserControl
    {
        internal SvFile fileData;

        //-------------------------------------------------------------------------------------------------------------------------------
        public UserControl_LevelTriggers()
        {
            InitializeComponent();

        }

        //*===============================================================================================
        //* PRINT DATA METHODS
        //*===============================================================================================
        internal void PrintLevelTriggers(SvFile savegameData)
        {
            fileData = savegameData;

            //Clear items
            if (lvwCurrentLevelTriggers.Items.Count > 0)
            {
                lvwCurrentLevelTriggers.Items.Clear();
            }

            //Add Data
            lvwCurrentLevelTriggers.BeginUpdate();
            foreach (KeyValuePair<uint, SvTrigger> triggerData in savegameData.cur_level_triggers)
            {
                ListViewItem itemData = new ListViewItem(new[] { triggerData.Value.trig_type.ToString(), triggerData.Value.trig_subtype.ToString(), triggerData.Value.saved_state_value.ToString(), triggerData.Value.vector_xyz.X.ToString(), triggerData.Value.vector_xyz.Y.ToString(), triggerData.Value.vector_xyz.Z.ToString() })
                {
                    Tag = triggerData.Key
                };
                lvwCurrentLevelTriggers.Items.Add(itemData);
            }
            lvwCurrentLevelTriggers.EndUpdate();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void LvwCurrentLevelTriggers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvwCurrentLevelTriggers.SelectedItems.Count > 0)
            {
                using (TriggerProperties objPropsForm = new TriggerProperties(lvwCurrentLevelTriggers, false))
                {
                    objPropsForm.ShowDialog();
                }
            }
        }

        //*===============================================================================================
        //* CONTEXT MENU
        //*===============================================================================================
        private void MenuItem_Add_Click(object sender, System.EventArgs e)
        {
            if (fileData != null)
            {
                using (TriggerProperties trigProps = new TriggerProperties(lvwCurrentLevelTriggers, true))
                {
                    trigProps.ShowDialog();
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_Modify_Click(object sender, System.EventArgs e)
        {
            if (lvwCurrentLevelTriggers.SelectedItems.Count > 0)
            {
                using (TriggerProperties trigProps = new TriggerProperties(lvwCurrentLevelTriggers, false))
                {
                    trigProps.ShowDialog();
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_Remove_Click(object sender, System.EventArgs e)
        {
            foreach (ListViewItem itemToRemove in lvwCurrentLevelTriggers.SelectedItems)
            {
                fileData.cur_level_triggers.Remove((uint)itemToRemove.Tag);
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
