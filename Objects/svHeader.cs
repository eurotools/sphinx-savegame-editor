using System.Collections.Generic;

namespace SavegameEditor.Objects
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    internal class SvHeader
    {
        internal uint version;
        internal uint game_time_sec;
        internal ushort scarabs;
        internal ushort health_ankhs;
        internal ushort crowns;
        internal string save_name_tag;
        internal uint cur_level_hashcode;
        internal uint cur_level_restart_id;
        internal int cur_level_entrance_id;
        internal int cur_level_timer;
        internal uint ActiveNotesSphinx;
        internal Dictionary<uint, uint> notes_sphinx = new Dictionary<uint, uint>();
        internal uint ActiveNotesMummy;
        internal Dictionary<uint, uint> notes_mummy = new Dictionary<uint, uint>();
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
