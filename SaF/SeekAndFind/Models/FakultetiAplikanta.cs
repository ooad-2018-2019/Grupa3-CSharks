using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeekAndFind.Models
{
    public class FakultetiAplikanta
    {
        public int FakultetiAplikantaId { get; set; }
        [System.ComponentModel.DisplayName("Fakultet ")]
        public int FakultetId { get; set; }
        public int AplikantId { get; set; }

        public virtual Fakultet Fakultet { get; set; }
        public virtual Aplikant Aplikant { get; set; }


    }
}
