using SavegameEditor.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
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
            int counter = 0;
            foreach (KeyValuePair<uint, SvVectorXYZW> playerPos in fileData.triple_mummy_copies_postition)
            {
                ListViewItem itemData = new ListViewItem(new[] { playerPos.Value.X.ToString(), playerPos.Value.Y.ToString(), playerPos.Value.Z.ToString(), playerPos.Value.W.ToString() })
                {
                    Tag = counter++
                };
                lvwTripMummyPos.Items.Add(itemData);
            }

            //Print rotation
            counter = 0;
            foreach (KeyValuePair<uint, SvVectorXYZW> playerRotation in fileData.triple_mummy_copies_rotation)
            {
                ListViewItem itemData = new ListViewItem(new[] { playerRotation.Value.X.ToString(), playerRotation.Value.Y.ToString(), playerRotation.Value.Z.ToString(), playerRotation.Value.W.ToString() })
                {
                    Tag = counter++
                };
                lvwTripMummyRot.Items.Add(itemData);
            }

            //Which Ability
            chkMum1Ability.Checked = Convert.ToBoolean(fileData.mummy_ability_which[0]);
            chkMum2Ability.Checked = Convert.ToBoolean(fileData.mummy_ability_which[1]);
            chkMum3Ability.Checked = Convert.ToBoolean(fileData.mummy_ability_which[2]);

            //Mummy ability current time
            nudMummy1_CurrTime.Value = fileData.mummy_ability_time_current[0];
            nudMummy2_CurrTime.Value = fileData.mummy_ability_time_current[1];
            nudMummy3_CurrTime.Value = fileData.mummy_ability_time_current[2];

            //Mummy ability max time
            nudMummy1_MaxTime.Value = fileData.mummy_ability_time_maximum[0];
            nudMummy2_MaxTime.Value = fileData.mummy_ability_time_maximum[1];
            nudMummy3_MaxTime.Value = fileData.mummy_ability_time_maximum[2];
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void CbxPlayerCharacter_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            if (fileData != null)
            {
                fileData.player_character_idx = (uint)cbxPlayerCharacter.SelectedIndex;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ChkMummyCopy1_CheckedChanged(object sender, System.EventArgs e)
        {
            if (fileData != null)
            {
                fileData.triple_mummy_copies_are_active[0] = Convert.ToByte(chkMummyCopy1.Checked);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ChkMummyCopy2_CheckedChanged(object sender, System.EventArgs e)
        {
            if (fileData != null)
            {
                fileData.triple_mummy_copies_are_active[1] = Convert.ToByte(chkMummyCopy2.Checked);
            }
        }

        //*===============================================================================================
        //* CONTEXT MENU MUMMY POSITION
        //*===============================================================================================
        private void MenuItem_Pos_Add_Click(object sender, EventArgs e)
        {
            if (fileData != null)
            {
                using (VectorSettings mumPosVector = new VectorSettings())
                {
                    if (mumPosVector.ShowDialog() == DialogResult.OK)
                    {
                        SvVectorXYZW posVector = new SvVectorXYZW
                        {
                            X = (float)mumPosVector.nudX.Value,
                            Y = (float)mumPosVector.nudY.Value,
                            Z = (float)mumPosVector.nudZ.Value,
                            W = (float)mumPosVector.nudW.Value
                        };

                        //Add item to dictionary
                        uint vectorKey = Globals.GetMaxValueArray(fileData.triple_mummy_copies_postition.Keys.ToArray()) + 1;
                        fileData.triple_mummy_copies_postition.Add(vectorKey, posVector);

                        //Add item to list
                        ListViewItem itemData = new ListViewItem(new[] { posVector.X.ToString(), posVector.Y.ToString(), posVector.Z.ToString(), posVector.W.ToString() })
                        {
                            Tag = vectorKey
                        };
                        lvwTripMummyPos.Items.Add(itemData);
                    }
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_Pos_Modify_Click(object sender, EventArgs e)
        {
            if (fileData != null)
            {
                using (VectorSettings mumPosVector = new VectorSettings())
                {
                    SvVectorXYZW currentVector = fileData.triple_mummy_copies_postition[(uint)lvwTripMummyPos.SelectedItems[0].Tag];
                    mumPosVector.nudX.Value = (decimal)currentVector.X;
                    mumPosVector.nudY.Value = (decimal)currentVector.Y;
                    mumPosVector.nudZ.Value = (decimal)currentVector.Z;
                    mumPosVector.nudW.Value = (decimal)currentVector.W;

                    //Update UI & object
                    if (mumPosVector.ShowDialog() == DialogResult.OK)
                    {
                        foreach (ListViewItem itemToModify in lvwTripMummyPos.SelectedItems)
                        {
                            currentVector = fileData.triple_mummy_copies_postition[(uint)itemToModify.Tag];
                            currentVector.X = (float)mumPosVector.nudX.Value;
                            currentVector.Y = (float)mumPosVector.nudY.Value;
                            currentVector.Z = (float)mumPosVector.nudZ.Value;
                            currentVector.W = (float)mumPosVector.nudW.Value;

                            itemToModify.SubItems[0].Text = currentVector.X.ToString();
                            itemToModify.SubItems[1].Text = currentVector.Y.ToString();
                            itemToModify.SubItems[2].Text = currentVector.Z.ToString();
                            itemToModify.SubItems[3].Text = currentVector.W.ToString();
                        }
                    }
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_Pos_Remove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itemToModify in lvwTripMummyPos.SelectedItems)
            {
                fileData.triple_mummy_copies_postition.Remove((uint)itemToModify.Tag);
                itemToModify.Remove();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void NudMummy1_CurrTime_MouseClick(object sender, MouseEventArgs e)
        {
            if (fileData != null)
            {
                fileData.mummy_ability_time_current[0] = (uint)nudMummy1_CurrTime.Value;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void NudMummy2_CurrTime_MouseClick(object sender, MouseEventArgs e)
        {
            if (fileData != null)
            {
                fileData.mummy_ability_time_current[1] = (uint)nudMummy2_CurrTime.Value;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void NudMummy3_CurrTime_MouseClick(object sender, MouseEventArgs e)
        {
            if (fileData != null)
            {
                fileData.mummy_ability_time_current[2] = (uint)nudMummy3_CurrTime.Value;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void NudMummy1_MaxTime_MouseClick(object sender, MouseEventArgs e)
        {
            if (fileData != null)
            {
                fileData.mummy_ability_time_maximum[0] = (uint)nudMummy1_MaxTime.Value;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void NudMummy2_MaxTime_MouseClick(object sender, MouseEventArgs e)
        {
            if (fileData != null)
            {
                fileData.mummy_ability_time_maximum[1] = (uint)nudMummy2_MaxTime.Value;
            }

        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void NudMummy3_MaxTime_MouseClick(object sender, MouseEventArgs e)
        {
            if (fileData != null)
            {
                fileData.mummy_ability_time_maximum[2] = (uint)nudMummy3_MaxTime.Value;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ChkMum1Ability_MouseClick(object sender, MouseEventArgs e)
        {
            if (fileData != null)
            {
                fileData.mummy_ability_which[0] = Convert.ToByte(chkMum1Ability.Checked);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ChkMum2Ability_MouseClick(object sender, MouseEventArgs e)
        {
            if (fileData != null)
            {
                fileData.mummy_ability_which[1] = Convert.ToByte(chkMum2Ability.Checked);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ChkMum3Ability_MouseClick(object sender, MouseEventArgs e)
        {
            if (fileData != null)
            {
                fileData.mummy_ability_which[2] = Convert.ToByte(chkMum3Ability.Checked);
            }
        }

        //*===============================================================================================
        //* CONTEXT MENU MUMMY ROTATION
        //*===============================================================================================
        private void MenuItem_Rot_Add_Click(object sender, EventArgs e)
        {
            if (fileData != null)
            {
                using (VectorSettings numRotVector = new VectorSettings())
                {
                    if (numRotVector.ShowDialog() == DialogResult.OK)
                    {
                        SvVectorXYZW rotVector = new SvVectorXYZW
                        {
                            X = (float)numRotVector.nudX.Value,
                            Y = (float)numRotVector.nudY.Value,
                            Z = (float)numRotVector.nudZ.Value,
                            W = (float)numRotVector.nudW.Value
                        };

                        //Add item to dictionary
                        uint vectorKey = Globals.GetMaxValueArray(fileData.triple_mummy_copies_rotation.Keys.ToArray()) + 1;
                        fileData.triple_mummy_copies_rotation.Add(vectorKey, rotVector);

                        //Add item to list
                        ListViewItem itemData = new ListViewItem(new[] { rotVector.X.ToString(), rotVector.Y.ToString(), rotVector.Z.ToString(), rotVector.W.ToString() })
                        {
                            Tag = vectorKey
                        };
                        lvwTripMummyRot.Items.Add(itemData);
                    }
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_Rot_Modify_Click(object sender, EventArgs e)
        {
            if (fileData != null)
            {
                using (VectorSettings mumRotVector = new VectorSettings())
                {
                    SvVectorXYZW currentVector = fileData.triple_mummy_copies_rotation[(uint)lvwTripMummyRot.SelectedItems[0].Tag];
                    mumRotVector.nudX.Value = (decimal)currentVector.X;
                    mumRotVector.nudY.Value = (decimal)currentVector.Y;
                    mumRotVector.nudZ.Value = (decimal)currentVector.Z;
                    mumRotVector.nudW.Value = (decimal)currentVector.W;

                    //Update UI & object
                    if (mumRotVector.ShowDialog() == DialogResult.OK)
                    {
                        foreach (ListViewItem itemToModify in lvwTripMummyRot.SelectedItems)
                        {
                            currentVector = fileData.triple_mummy_copies_rotation[(uint)itemToModify.Tag];
                            currentVector.X = (float)mumRotVector.nudX.Value;
                            currentVector.Y = (float)mumRotVector.nudY.Value;
                            currentVector.Z = (float)mumRotVector.nudZ.Value;
                            currentVector.W = (float)mumRotVector.nudW.Value;

                            itemToModify.SubItems[0].Text = currentVector.X.ToString();
                            itemToModify.SubItems[1].Text = currentVector.Y.ToString();
                            itemToModify.SubItems[2].Text = currentVector.Z.ToString();
                            itemToModify.SubItems[3].Text = currentVector.W.ToString();
                        }
                    }
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_Rot_Delete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itemToModify in lvwTripMummyRot.SelectedItems)
            {
                fileData.triple_mummy_copies_rotation.Remove((uint)itemToModify.Tag);
                itemToModify.Remove();
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
