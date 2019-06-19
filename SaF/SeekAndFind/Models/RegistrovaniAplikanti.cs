using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeekAndFind.Models
{
    public class RegistrovaniAplikanti
    {
        public int RegistrovaniAplikantiId { get; set; }
        public int KorisnikId { get; set; }
        public int OglasId { get; set; }

        public virtual Oglas Oglas { get; set; }
        public virtual Aplikant Aplikant { get; set; }
    }
}
