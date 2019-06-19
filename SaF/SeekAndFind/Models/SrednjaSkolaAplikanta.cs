using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeekAndFind.Models
{
    public class SrednjaSkolaAplikanta
    {
        public int SrednjaSkolaAplikantaId { get; set; }
        [System.ComponentModel.DisplayName("Srednja škola ")]
        public int SrednjaSkolaId { get; set; }
        public int AplikantId { get; set; }

        public virtual SrednjaSkola SrednjaSkola { get; set; }
        public virtual Aplikant Aplikant { get; set; }
    }
}
