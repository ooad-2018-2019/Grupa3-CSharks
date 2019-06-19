using SeekAndFind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeekAndFind.Models.ViewModels
{
    public class OglasData
    {
        public IEnumerable<Oglas> Oglasi { get; set; }
        public IEnumerable<Jezik> Jezici { get; set; }
        public IEnumerable<Fakultet> Fakulteti { get; set; }
        public IEnumerable<SrednjaSkola> SrednjeSkole { get; set; }
    }
}
