using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denemeler
{
    internal class Static
    {
        public string title;
        public string artist;
        public int duration;
        public static int songCount;

        public Static(string atitle, string aArtist, int aDuration )
        {
            title = atitle;
            artist = aArtist;   
            duration = aDuration;
        }
    }
}
