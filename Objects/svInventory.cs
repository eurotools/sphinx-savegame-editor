using System.Collections.Generic;

namespace SavegameEditor.Objects
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    internal class SvInventory
    {
        internal uint filter_include;
        internal uint filter_exclude;
        internal uint filter_optional;
        internal uint current_cycle;
        internal List<SvItemCycle> item_cycles = new List<SvItemCycle>();
    }

    //-------------------------------------------------------------------------------------------------------------------------------
    internal class SvItemCycle
    {
        internal uint cur_sel_item;
        internal Dictionary<uint, SvInvItem> items = new Dictionary<uint, SvInvItem>();
    }

    //-------------------------------------------------------------------------------------------------------------------------------
    internal class SvInvItem
    {
        internal uint hashcode;
        internal int count_cur;
        internal int count_max;
        internal uint flags;
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
