using System;
using System.Collections.Generic;

namespace SeekAndFindWebServis
{
    public partial class RadnoIskustvoAplikanta
    {
        public int RadnoIskustvoAplikantaId { get; set; }
        public int RadnoIskustvoId { get; set; }
        public int AplikantId { get; set; }

        public Korisnik Aplikant { get; set; }
        public RadnoIskustvo RadnoIskustvo { get; set; }
    }
}
