using System;
using System.Collections.Generic;

namespace SeekAndFindWebServis
{
    public partial class SrednjaSkolaAplikanta
    {
        public int SrednjaSkolaAplikantaId { get; set; }
        public int SrednjaSkolaId { get; set; }
        public int AplikantId { get; set; }

        public Korisnik Aplikant { get; set; }
        public SrednjaSkola SrednjaSkola { get; set; }
    }
}
