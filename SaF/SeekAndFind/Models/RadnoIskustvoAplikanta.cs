using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeekAndFind.Models
{
    public class RadnoIskustvoAplikanta
    {
        public int RadnoIskustvoAplikantaId { get; set; }
        public int RadnoIskustvoId { get; set; }
        public int AplikantId { get; set; }

        public virtual Aplikant Aplikant { get; set; }
        public virtual RadnoIskustvo RadnoIskustvo { get; set; }

    }
}
