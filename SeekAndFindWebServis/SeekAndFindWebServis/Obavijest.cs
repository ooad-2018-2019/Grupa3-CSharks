using System;
using System.Collections.Generic;

namespace SeekAndFindWebServis
{
    public partial class Obavijest
    {
        public int ObavijestId { get; set; }
        public int AplikantId { get; set; }
        public int OglasId { get; set; }

        public Korisnik Aplikant { get; set; }
        public Oglas Oglas { get; set; }
    }
}
