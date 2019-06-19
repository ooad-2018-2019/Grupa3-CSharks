using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeekAndFind.Models
{
    public class Obavijest
    {
        public int ObavijestId { get; set; }
        public int AplikantId { get; set; }
        public int OglasId { get; set; }

        public virtual Oglas Oglas { get; set; }
        public virtual Aplikant Aplikant { get; set; }
    }
}
