using SavegameEditor.Objects;
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
            foreach (var triggerData in savegameData.cur_level_triggers)
            {
                lvwCurrentLevelTriggers.Items.Add(new ListViewItem(new[] { triggerData.trig_type.ToString(), triggerData.trig_subtype.ToString(), triggerData.saved_state_value.ToString(), triggerData.vector_xyz.X.ToString(), triggerData.vector_xyz.Y.ToString(), triggerData.vector_xyz.Z.ToString() }));
            }
            lvwCurrentLevelTriggers.EndUpdate();
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
