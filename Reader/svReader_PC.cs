using SavegameEditor.Objects;
using System.Collections.Generic;
using System.IO;

namespace SavegameEditor.Reader
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    internal class SvReader_PC
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        public SvFile ReadFile(string filePath)
        {
            SvFile fileData = new SvFile();
            using (BinaryReader binReader = new BinaryReader(File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.Read)))
            {
                //Read file header
                fileData.headerData.version = binReader.ReadUInt32();
                if (fileData.headerData.version == 134348804)
                {
                    binReader.BaseStream.Seek(4, SeekOrigin.Current);
                    fileData.headerData.game_time_sec = binReader.ReadUInt32();
                    fileData.headerData.scarabs = binReader.ReadUInt16();
                    fileData.headerData.health_ankhs = binReader.ReadUInt16();
                    fileData.headerData.crowns = binReader.ReadUInt16();
                    fileData.headerData.save_name_tag = new string(binReader.ReadChars(16));
                    binReader.BaseStream.Seek(2, SeekOrigin.Current);
                    fileData.headerData.cur_level_hashcode = binReader.ReadUInt32();
                    fileData.headerData.cur_level_restart_id = binReader.ReadUInt32();
                    fileData.headerData.cur_level_entrance_id = binReader.ReadInt32();
                    fileData.headerData.cur_level_timer = binReader.ReadInt32();

                    //Read Sphinx Notes
                    binReader.BaseStream.Seek(0x3C, SeekOrigin.Begin);
                    ReadNotes(binReader, fileData.headerData.notes_sphinx, 10, ref fileData.headerData.ActiveNotesSphinx);

                    //Read Mummy Notes
                    binReader.BaseStream.Seek(0x94, SeekOrigin.Begin);
                    ReadNotes(binReader, fileData.headerData.notes_mummy, 10, ref fileData.headerData.ActiveNotesMummy);

                    //Objectives
                    binReader.BaseStream.Seek(0xEC, SeekOrigin.Begin);
                    uint objective_count = binReader.ReadUInt32();
                    for (int i = 0; i <= objective_count; i++)
                    {
                        fileData.Objectives.Add(binReader.ReadUInt32(), binReader.ReadUInt32());
                    }

                    //Secondary header fields
                    binReader.BaseStream.Seek(0x3610, SeekOrigin.Begin);
                    fileData.health_thirds = binReader.ReadUInt32();
                    fileData.total_health_thirds = binReader.ReadUInt32();

                    //Sphinx inventory
                    binReader.BaseStream.Seek(0x3618, SeekOrigin.Begin);
                    ReadInventory(binReader, fileData.sphinx_inventory);

                    //Mummy inventory
                    binReader.BaseStream.Seek(0x73A4, SeekOrigin.Begin);
                    ReadInventory(binReader, fileData.mummy_inventory);

                    //Current level saved triggers
                    binReader.BaseStream.Seek(0xB2C4, SeekOrigin.Begin);
                    ReadTriggers(binReader, fileData.cur_level_triggers);

                    //Active player
                    binReader.BaseStream.Seek(0xBC28, SeekOrigin.Begin);
                    fileData.player_character_idx = binReader.ReadUInt32();

                    //Mummy Ability Which
                    binReader.BaseStream.Seek(0xBC2C, SeekOrigin.Begin);
                    fileData.mummy_ability_which = ReadMummyAbilityVector(binReader);

                    //Mummy Ability Time Current
                    binReader.BaseStream.Seek(0xBC38, SeekOrigin.Begin);
                    fileData.mummy_ability_time_current = ReadMummyAbilityVector(binReader);

                    //Mummy Ability Time Maximum
                    binReader.BaseStream.Seek(0xBC44, SeekOrigin.Begin);
                    fileData.mummy_ability_time_maximum = ReadMummyAbilityVector(binReader);

                    //Triple mummy
                    binReader.BaseStream.Seek(0xBC50, SeekOrigin.Begin);
                    ReadTripleMummyCopies(binReader, fileData);

                    //Read Camera Settings
                    binReader.BaseStream.Seek(0xBC98, SeekOrigin.Begin);
                    ReadCameraSettings(binReader, fileData);

                    //Read Programmable buttons
                    binReader.BaseStream.Seek(0xBCB4, SeekOrigin.Begin);
                    ReadProgrammableButtons(binReader, fileData.mummy_prog_buttons);

                    binReader.BaseStream.Seek(0xBCC4, SeekOrigin.Begin);
                    ReadProgrammableButtons(binReader, fileData.sphinx_prog_buttons);
                }
                else
                {
                    throw new InvalidDataException(string.Format("Loading File: {0}\n\nError: {0} has a bad format.", filePath));
                }
            }

            return fileData;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ReadNotes(BinaryReader binReader, Dictionary<uint, uint> destList, int numNotes, ref uint activeNotes)
        {
            binReader.BaseStream.Seek(4, SeekOrigin.Current);
            for (int i = 0; i < numNotes; i++)
            {
                uint title_hashcode = binReader.ReadUInt32();
                uint desc_hashcode = binReader.ReadUInt32();
                if (title_hashcode != 0 && desc_hashcode != 0)
                {
                    destList.Add(title_hashcode, desc_hashcode);
                }
            }
            activeNotes = binReader.ReadUInt32();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ReadInventory(BinaryReader binReader, SvInventory inventoryObj)
        {
            inventoryObj.filter_include = binReader.ReadUInt32();
            inventoryObj.filter_exclude = binReader.ReadUInt32();
            inventoryObj.filter_optional = binReader.ReadUInt32();
            inventoryObj.current_cycle = binReader.ReadUInt32();
            uint cycleCount = binReader.ReadUInt32();
            for (int i = 0; i < cycleCount; i++)
            {
                SvItemCycle cycleData = new SvItemCycle
                {
                    cur_sel_item = binReader.ReadUInt32()
                };
                uint item_count = binReader.ReadUInt32();
                for (int j = 0; j < 140; j++)
                {
                    if (j >= item_count)
                    {
                        binReader.BaseStream.Seek(16, SeekOrigin.Current);
                        continue;
                    }

                    SvInvItem itemData = new SvInvItem
                    {
                        hashcode = binReader.ReadUInt32(),
                        count_cur = binReader.ReadInt32(),
                        count_max = binReader.ReadInt32(),
                        flags = binReader.ReadUInt32()
                    };
                    cycleData.items.Add(itemData.hashcode, itemData);
                }
                inventoryObj.item_cycles.Add(cycleData);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ReadTriggers(BinaryReader binReader, List<SvTrigger> triggersList)
        {
            uint triggersCount = binReader.ReadUInt32();
            for (int i = 0; i < triggersCount; i++)
            {
                SvTrigger triggerData = new SvTrigger
                {
                    trig_type = binReader.ReadUInt32(),
                    trig_subtype = binReader.ReadUInt32(),
                    saved_state_value = binReader.ReadUInt32()
                };
                triggerData.vector_xyz.X = binReader.ReadSingle();
                triggerData.vector_xyz.Y = binReader.ReadSingle();
                triggerData.vector_xyz.Z = binReader.ReadSingle();
                triggersList.Add(triggerData);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ReadTripleMummyCopies(BinaryReader binReader, SvFile fileData)
        {
            fileData.triple_mummy_copies_are_active[0] = binReader.ReadUInt32();
            fileData.triple_mummy_copies_are_active[1] = binReader.ReadUInt32();

            //Read Mummy Positions
            binReader.BaseStream.Seek(0xBC58, SeekOrigin.Begin);
            ReadMummyVectors(binReader, fileData.triple_mummy_copies_are_active, fileData.triple_mummy_copies_postition);

            //Read Mummy Rotations
            binReader.BaseStream.Seek(0xBC78, SeekOrigin.Begin);
            ReadMummyVectors(binReader, fileData.triple_mummy_copies_are_active, fileData.triple_mummy_copies_rotation);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ReadMummyVectors(BinaryReader binReader, uint[] activeCopies, List<SvVectorXYZW> vectorsList)
        {
            for (int i = 0; i < activeCopies.Length; i++)
            {
                if (activeCopies[i] == 1)
                {
                    SvVectorXYZW mummyPos = new SvVectorXYZW
                    {
                        X = binReader.ReadSingle(),
                        Y = binReader.ReadSingle(),
                        Z = binReader.ReadSingle(),
                        W = binReader.ReadSingle()
                    };
                    vectorsList.Add(mummyPos);
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ReadCameraSettings(BinaryReader binReader, SvFile fileData)
        {
            fileData.cameraSettings.camera_angle = binReader.ReadSingle();
            fileData.cameraSettings.camera_elevation = binReader.ReadSingle();
            fileData.cameraSettings.camera_distance = binReader.ReadSingle();
            fileData.cameraSettings.camera_position.X = binReader.ReadSingle();
            fileData.cameraSettings.camera_position.Y = binReader.ReadSingle();
            fileData.cameraSettings.camera_position.Z = binReader.ReadSingle();
            fileData.cameraSettings.camera_position.W = binReader.ReadSingle();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ReadProgrammableButtons(BinaryReader binReader, uint[] DestArray)
        {
            DestArray[0] = binReader.ReadUInt32();
            DestArray[1] = binReader.ReadUInt32();
            DestArray[2] = binReader.ReadUInt32();
            DestArray[3] = binReader.ReadUInt32();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private uint[] ReadMummyAbilityVector(BinaryReader binReader)
        {
            uint[] vectorData = new uint[3];
            for (int i = 0; i < 3; i++)
            {
                uint data = binReader.ReadUInt32();
                if (data != 0xA8A8A8A8)
                {
                    vectorData[i] = data;
                }
            }

            return vectorData;
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
