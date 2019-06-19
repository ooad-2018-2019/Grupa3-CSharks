using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeekAndFind.Models.ViewModels
{
    public class AplikantData
    {
        public Aplikant Aplikant { get; set;  }
        public IEnumerable<Jezik> Jezici { get; set; }
        public IEnumerable<JeziciAplikanta> JeziciAplikanta { get; set; }
        public IEnumerable<Fakultet> Fakulteti { get; set; }
        public IEnumerable<Obavijest> Obavijesti { get; set; }
        public IEnumerable<SrednjaSkola> SrednjeSkole { get; set; }
        public IEnumerable<RadnoIskustvo> RadnoIskustvo { get; set; }
        public Korisnik Korisnik { get; set; }


    }
}
