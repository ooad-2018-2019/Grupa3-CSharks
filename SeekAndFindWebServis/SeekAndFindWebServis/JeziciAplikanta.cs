using System;
using System.Collections.Generic;

namespace SeekAndFindWebServis
{
    public partial class JeziciAplikanta
    {
        public int JeziciAplikantaId { get; set; }
        public int AplikantId { get; set; }
        public int JezikId { get; set; }
        public int NivoCitanja { get; set; }
        public int NivoPisanja { get; set; }

        public Korisnik Aplikant { get; set; }
        public Jezik Jezik { get; set; }
    }
}
