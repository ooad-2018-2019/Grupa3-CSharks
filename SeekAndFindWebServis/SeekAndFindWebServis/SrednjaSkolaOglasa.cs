using System;
using System.Collections.Generic;

namespace SeekAndFindWebServis
{
    public partial class SrednjaSkolaOglasa
    {
        public string SrednjaSkolaOglasaId { get; set; }
        public int SrednjaSkolaId { get; set; }
        public int OglasId { get; set; }

        public Oglas Oglas { get; set; }
        public SrednjaSkola SrednjaSkola { get; set; }
    }
}
