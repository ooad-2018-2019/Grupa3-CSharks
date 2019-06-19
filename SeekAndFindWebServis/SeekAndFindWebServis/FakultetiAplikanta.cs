using System;
using System.Collections.Generic;

namespace SeekAndFindWebServis
{
    public partial class FakultetiAplikanta
    {
        public int FakultetiAplikantaId { get; set; }
        public int FakultetId { get; set; }
        public int AplikantId { get; set; }

        public Korisnik Aplikant { get; set; }
        public Fakultet Fakultet { get; set; }
    }
}
