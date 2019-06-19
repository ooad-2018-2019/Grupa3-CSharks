using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeekAndFind.Models
{
    public class SrednjaSkolaOglasa

    {
        public string SrednjaSkolaOglasaId { get; set; }
        public int SrednjaSkolaId { get; set; }
        public int OglasId { get; set; }        public virtual SrednjaSkola SrednjaSkola { get; set; }
        public virtual Oglas Oglas { get; set; }
    }
}
