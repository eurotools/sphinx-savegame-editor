using System.Collections.Generic;

namespace SavegameEditor.Objects
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    internal class SvFile
    {
        internal SvHeader headerData = new SvHeader();
        internal Dictionary<uint, uint> Objectives = new Dictionary<uint, uint>();
        internal uint health_thirds;
        internal uint total_health_thirds;
        internal SvInventory sphinx_inventory = new SvInventory();
        internal SvInventory mummy_inventory = new SvInventory();
        internal List<SvTrigger> cur_level_triggers = new List<SvTrigger>();
        internal uint player_character_idx;
        internal uint[] mummy_ability_which = new uint[3];
        internal uint[] mummy_ability_time_current = new uint[3];
        internal uint[] mummy_ability_time_maximum = new uint[3];
        internal uint[] triple_mummy_copies_are_active = new uint[2];
        internal List<SvVectorXYZW> triple_mummy_copies_postition = new List<SvVectorXYZW>();
        internal List<SvVectorXYZW> triple_mummy_copies_rotation = new List<SvVectorXYZW>();
        internal SvCamera cameraSettings = new SvCamera();
        internal uint[] mummy_prog_buttons = new uint[4];
        internal uint[] sphinx_prog_buttons = new uint[4];
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}