using System;
using System.Collections.Generic;

namespace SeekAndFindWebServis
{
    public partial class SrednjaSkola
    {
        public SrednjaSkola()
        {
            SrednjaSkolaAplikanta = new HashSet<SrednjaSkolaAplikanta>();
            SrednjaSkolaOglasa = new HashSet<SrednjaSkolaOglasa>();
        }

        public int SrednjaSkolaId { get; set; }
        public string Naziv { get; set; }

        public ICollection<SrednjaSkolaAplikanta> SrednjaSkolaAplikanta { get; set; }
        public ICollection<SrednjaSkolaOglasa> SrednjaSkolaOglasa { get; set; }
    }
}
