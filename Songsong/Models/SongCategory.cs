using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Songsong.Models
{
    public class SongCategory
    {
        public int SongID { get; set; }

        public int CategoryID { get; set; }

        public Song Song { get; set; }

        public Category Category { get; set; }
    }
}
