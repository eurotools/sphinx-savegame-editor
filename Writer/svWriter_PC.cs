using Force.Crc32;
using SavegameEditor.Objects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SavegameEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    internal class SvWriter_PC
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        internal void WriteFile(string filePath, SvFile fileData)
        {
            using (MemoryStream memStream = new MemoryStream())
            {
                using (BinaryWriter binWriter = new BinaryWriter(memStream))
                {
                    binWriter.Write((ushort)4);
                    binWriter.Write((ushort)(Globals.MaximumObjectives + Globals.MaximumInventoryItems + Globals.MaximumAbilityItems + Globals.MaximumSavedTriggers));
                    binWriter.Write((ushort)4);
                    binWriter.Write((ushort)(Globals.MaximumObjectives + Globals.MaximumInventoryItems + Globals.MaximumAbilityItems + Globals.MaximumSavedTriggers));
                    binWriter.Write(fileData.headerData.game_time_sec);
                    binWriter.Write(fileData.headerData.scarabs);
                    binWriter.Write(fileData.headerData.health_ankhs);
                    binWriter.Write(fileData.headerData.crowns);
                    char[] gameNameTag = new char[16];
                    Globals.GameLabel.CopyTo(0, gameNameTag, 0, Math.Min(Globals.GameLabel.Length, gameNameTag.Length));
                    binWriter.Write(gameNameTag);
                    WriteAlignedDecoration(binWriter, AlignNumber((uint)binWriter.BaseStream.Position, 4));
                    binWriter.Write(fileData.headerData.cur_level_hashcode);
                    binWriter.Write(fileData.headerData.cur_level_restart_id);
                    binWriter.Write(fileData.headerData.cur_level_entrance_id);
                    binWriter.Write(fileData.headerData.cur_level_timer);
                    binWriter.Write(fileData.headerData.game_time_sec);

                    //Write Sphinx Notes
                    WriteAlignedDecoration(binWriter, AlignNumber((uint)binWriter.BaseStream.Position, 12));
                    WriteNotes(binWriter, fileData.headerData.notes_sphinx, fileData.headerData.ActiveNotesSphinx);

                    //Write Mummy Notes
                    WriteAlignedDecoration(binWriter, AlignNumber((uint)binWriter.BaseStream.Position, 5));
                    WriteNotes(binWriter, fileData.headerData.notes_mummy, fileData.headerData.ActiveNotesMummy);

                    //Objectives
                    binWriter.BaseStream.Seek(0xEC, SeekOrigin.Begin);
                    WriteObjectives(binWriter, fileData.Objectives);

                    //Secondary header fields
                    binWriter.BaseStream.Seek(0x3610, SeekOrigin.Begin);
                    binWriter.Write(fileData.health_thirds);
                    binWriter.Write(fileData.total_health_thirds);

                    //Sphinx inventory
                    binWriter.BaseStream.Seek(0x3618, SeekOrigin.Begin);
                    WriteInventory(binWriter, fileData.sphinx_inventory);

                    //Mummy inventory
                    WriteAlignedDecoration(binWriter, (uint)(binWriter.BaseStream.Position + (0x73A4 - binWriter.BaseStream.Position)));
                    WriteInventory(binWriter, fileData.mummy_inventory);

                    //Ability Items
                    WriteAlignedDecoration(binWriter, (uint)(binWriter.BaseStream.Position + (0xB130 - binWriter.BaseStream.Position)));
                    binWriter.Write(0);

                    //Current level saved triggers
                    WriteAlignedDecoration(binWriter, (uint)(binWriter.BaseStream.Position + (0xB2C4 - binWriter.BaseStream.Position)));
                    WriteTriggers(binWriter, fileData.cur_level_triggers);

                    //Active player
                    WriteAlignedDecoration(binWriter, (uint)(binWriter.BaseStream.Position + (0xBC28 - binWriter.BaseStream.Position)));
                    binWriter.Write(fileData.player_character_idx);

                    //Mummy Ability Which
                    WriteMummyAbilityVector(binWriter, fileData.triple_mummy_copies_are_active, fileData.mummy_ability_which);

                    //Mummy Ability Time Current
                    WriteMummyAbilityVector(binWriter, fileData.triple_mummy_copies_are_active, fileData.mummy_ability_time_current);

                    //Mummy Ability Which
                    WriteMummyAbilityVector(binWriter, fileData.triple_mummy_copies_are_active, fileData.mummy_ability_time_maximum);

                    //Triple mummy
                    WriteAlignedDecoration(binWriter, (uint)(binWriter.BaseStream.Position + (0xBC50 - binWriter.BaseStream.Position)));
                    WriteTripleMummyCopies(binWriter, fileData);

                    //Write Camera Settings
                    WriteCameraSettings(binWriter, fileData);

                    //Write Programmable buttons
                    WriteProgrammableButtons(binWriter, fileData.mummy_prog_buttons);
                    WriteProgrammableButtons(binWriter, fileData.sphinx_prog_buttons);

                    //CRC32
                    WriteAlignedDecoration(binWriter, AlignNumber((uint)binWriter.BaseStream.Position, 8));
                    binWriter.Write(0);
                }

                //Calculate and add crc32
                byte[] saveGameData = memStream.ToArray();
                Crc32Algorithm.ComputeAndWriteToEnd(saveGameData, 0, saveGameData.Length - 4);

                //Write file data
                File.WriteAllBytes(filePath, saveGameData);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void WriteNotes(BinaryWriter binWriter, Dictionary<uint, uint> NotesDictionary, uint ActiveNotes)
        {
            for (int i = 0; i < Globals.MaximumInventoryNotes; i++)
            {
                uint titleHashcode = 0;
                uint descHashCode = 0;
                if (i < NotesDictionary.Count)
                {
                    KeyValuePair<uint, uint> element = NotesDictionary.ElementAt(i);
                    titleHashcode = element.Key;
                    descHashCode = element.Value;
                }
                binWriter.Write(titleHashcode);
                binWriter.Write(descHashCode);
            }
            binWriter.Write(ActiveNotes);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void WriteObjectives(BinaryWriter binWriter, Dictionary<uint, uint> Objectives)
        {
            binWriter.Write(Objectives.Count - 1);
            foreach (KeyValuePair<uint, uint> objective in Objectives)
            {
                binWriter.Write(objective.Key);
                binWriter.Write(objective.Value);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void WriteInventory(BinaryWriter binWriter, SvInventory inventoryObj)
        {
            binWriter.Write(inventoryObj.filter_include);
            binWriter.Write(inventoryObj.filter_exclude);
            binWriter.Write(inventoryObj.filter_optional);
            binWriter.Write(inventoryObj.current_cycle);
            binWriter.Write(inventoryObj.item_cycles.Count);
            foreach (SvItemCycle invData in inventoryObj.item_cycles)
            {
                binWriter.Write(invData.cur_sel_item);
                binWriter.Write(invData.items.Count);
                foreach (KeyValuePair<uint, SvInvItem> itemData in invData.items)
                {
                    binWriter.Write(itemData.Value.hashcode);
                    binWriter.Write(itemData.Value.count_cur);
                    binWriter.Write(itemData.Value.count_max);
                    binWriter.Write(itemData.Value.flags);
                }
                for (int i = invData.items.Count; i < 140; i++)
                {
                    binWriter.Write(0xA8A8A8A8);
                    binWriter.Write(0xA8A8A8A8);
                    binWriter.Write(0xA8A8A8A8);
                    binWriter.Write(0xA8A8A8A8);
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void WriteTriggers(BinaryWriter binWriter, Dictionary<uint, SvTrigger> triggers)
        {
            binWriter.Write(triggers.Count);
            foreach (SvTrigger triggerData in triggers.Values)
            {
                binWriter.Write(triggerData.trig_type);
                binWriter.Write(triggerData.trig_subtype);
                binWriter.Write(triggerData.saved_state_value);
                binWriter.Write(triggerData.vector_xyz.X);
                binWriter.Write(triggerData.vector_xyz.Y);
                binWriter.Write(triggerData.vector_xyz.Z);
            }
            for (int i = triggers.Count; i < 100; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    binWriter.Write(0);
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void WriteTripleMummyCopies(BinaryWriter binWriter, SvFile fileData)
        {
            for (int i = 0; i < fileData.triple_mummy_copies_are_active.Length; i++)
            {
                binWriter.Write(fileData.triple_mummy_copies_are_active[i]);
            }

            //Write Mummy Positions
            binWriter.BaseStream.Seek(0xBC58, SeekOrigin.Begin);
            WriteMummyVectors(binWriter, fileData.triple_mummy_copies_are_active, fileData.triple_mummy_copies_postition);

            //Write Mummy Rotations
            binWriter.BaseStream.Seek(0xBC78, SeekOrigin.Begin);
            WriteMummyVectors(binWriter, fileData.triple_mummy_copies_are_active, fileData.triple_mummy_copies_rotation);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void WriteMummyVectors(BinaryWriter binWriter, uint[] activeCopies, List<SvVectorXYZW> vectorsList)
        {
            for (int i = 0; i < activeCopies.Length; i++)
            {
                if (activeCopies[i] == 1)
                {
                    SvVectorXYZW mummyPos = vectorsList[i];
                    binWriter.Write(mummyPos.X);
                    binWriter.Write(mummyPos.Y);
                    binWriter.Write(mummyPos.Z);
                    binWriter.Write(mummyPos.W);
                }
                else
                {
                    binWriter.Write(0xA8A8A8A8);
                    binWriter.Write(0xA8A8A8A8);
                    binWriter.Write(0xA8A8A8A8);
                    binWriter.Write(0xA8A8A8A8);
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void WriteCameraSettings(BinaryWriter binWriter, SvFile fileData)
        {
            SvCamera cameraSettings = fileData.cameraSettings;
            binWriter.Write(cameraSettings.camera_angle);
            binWriter.Write(cameraSettings.camera_elevation);
            binWriter.Write(cameraSettings.camera_distance);
            binWriter.Write(cameraSettings.camera_position.X);
            binWriter.Write(cameraSettings.camera_position.Y);
            binWriter.Write(cameraSettings.camera_position.Z);
            binWriter.Write(cameraSettings.camera_position.W);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void WriteProgrammableButtons(BinaryWriter binWriter, uint[] array)
        {
            binWriter.Write(array[0]);
            binWriter.Write(array[1]);
            binWriter.Write(array[2]);
            binWriter.Write(array[3]);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void WriteMummyAbilityVector(BinaryWriter binWriter, uint[] tripleMummyCopies, uint[] arrayToWrite)
        {
            for (int i = 0; i < arrayToWrite.Length; i++)
            {
                if (i > 0 && tripleMummyCopies[i - 1] == 0)
                {
                    binWriter.Write(0xA8A8A8A8);
                }
                else
                {
                    binWriter.Write(arrayToWrite[i]);
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private uint AlignNumber(uint valueToAlign, uint blockSize)
        {
            uint PositionAligned = (valueToAlign + (blockSize - 1)) & ~(blockSize - 1);
            return PositionAligned;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void WriteAlignedDecoration(BinaryWriter bw, uint PositionAligned)
        {
            while (bw.BaseStream.Position != PositionAligned)
            {
                bw.Write((byte)0xA8);
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
