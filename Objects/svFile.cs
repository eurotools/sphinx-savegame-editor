using System.Collections.Generic;

namespace SavegameEditor.Objects
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    internal class SvFile
    {
        internal Dictionary<uint, SvTrigger> cur_level_triggers = new Dictionary<uint, SvTrigger>();
        internal Dictionary<uint, SvVectorXYZW> triple_mummy_copies_postition = new Dictionary<uint, SvVectorXYZW>();
        internal Dictionary<uint, SvVectorXYZW> triple_mummy_copies_rotation = new Dictionary<uint, SvVectorXYZW>();
        internal Dictionary<uint, uint> Objectives = new Dictionary<uint, uint>();
        internal SvInventory sphinx_inventory = new SvInventory();
        internal SvInventory mummy_inventory = new SvInventory();
        internal uint[] triple_mummy_copies_are_active = new uint[2];
        internal uint[] mummy_ability_time_current = new uint[3];
        internal uint[] mummy_ability_time_maximum = new uint[3];
        internal uint[] mummy_ability_which = new uint[3];
        internal SvCamera cameraSettings = new SvCamera();
        internal uint[] sphinx_prog_buttons = new uint[4];
        internal uint[] mummy_prog_buttons = new uint[4];
        internal SvHeader headerData = new SvHeader();
        internal uint player_character_idx;
        internal uint total_health_thirds;
        internal uint health_thirds;
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}