using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeekAndFind.Models.ViewModels
{
    public class TopOglas
    {
        public IEnumerable<Oglas> Oglasi { get; set; }
        public Korisnik Korisnik { get; set; }
    }
}
