using SavegameEditor.Objects;
using System.Windows.Forms;

namespace SavegameEditor.Forms.Panels
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class UserControl_PlayerData : UserControl
    {
        internal SvFile fileData;

        //-------------------------------------------------------------------------------------------------------------------------------
        public UserControl_PlayerData()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal void PrintPlayerData(SvFile savegameData)
        {
            fileData = savegameData;

            //Player data properties
            cbxPlayerCharacter.SelectedIndex = (int)fileData.player_character_idx;
            chkMummyCopy1.Checked = fileData.triple_mummy_copies_are_active[0] == 1;
            chkMummyCopy2.Checked = fileData.triple_mummy_copies_are_active[1] == 1;

            //Print position
            foreach (SvVectorXYZW playerPos in fileData.triple_mummy_copies_postition)
            {
                lvwTripMummyPos.Items.Add(new ListViewItem(new[] { playerPos.X.ToString(), playerPos.Y.ToString(), playerPos.Z.ToString(), playerPos.W.ToString() }));
            }

            //Print rotation
            foreach (SvVectorXYZW playerRotation in fileData.triple_mummy_copies_rotation)
            {
                lvwTripMummyRot.Items.Add(new ListViewItem(new[] { playerRotation.X.ToString(), playerRotation.Y.ToString(), playerRotation.Z.ToString(), playerRotation.W.ToString() }));
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        internal void PrintCharactersData(SvFile saveGameData)
        {
            fileData = saveGameData;

            cbxPlayerCharacter.SelectedIndex = (int)saveGameData.player_character_idx;
            chkMummyCopy1.Checked = saveGameData.triple_mummy_copies_are_active[0] == 1;
            chkMummyCopy2.Checked = saveGameData.triple_mummy_copies_are_active[1] == 1;

            //Print position
            lvwTripMummyPos.BeginUpdate();
            foreach (SvVectorXYZW mummyPos in saveGameData.triple_mummy_copies_postition)
            {
                lvwTripMummyPos.Items.Add(new ListViewItem(new[] { mummyPos.X.ToString(), mummyPos.Y.ToString(), mummyPos.Z.ToString(), mummyPos.W.ToString() }));
            }
            lvwTripMummyPos.EndUpdate();

            //Print position
            lvwTripMummyRot.BeginUpdate();
            foreach (SvVectorXYZW mummyRot in saveGameData.triple_mummy_copies_postition)
            {
                lvwTripMummyRot.Items.Add(new ListViewItem(new[] { mummyRot.X.ToString(), mummyRot.Y.ToString(), mummyRot.Z.ToString(), mummyRot.W.ToString() }));
            }
            lvwTripMummyRot.EndUpdate();
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
