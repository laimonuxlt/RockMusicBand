using System;
using System.Collections.Generic;
using System.Text;

namespace RockMusicBand
{
    class BandNoun
    {
        public int Id { get; set; }
        public string Noun { get; set; }

        public override string ToString()
        {
            return $"{Noun}"; 
        }
    }
}
