using System;
using System.Collections.Generic;
using System.Text;

namespace RockMusicBand
{
    class BandWithMembers
    {
        public string BandName { get; set; }

        public IEnumerable<BandMember> BandMembers { get; set; }
    }
}
