using System;
using System.Collections.Generic;

namespace SeekAndFindWebServis
{
    public partial class FakultetiOglasa
    {
        public string FakultetiOglasaId { get; set; }
        public int FakultetId { get; set; }
        public int OglasId { get; set; }

        public Fakultet Fakultet { get; set; }
        public Oglas Oglas { get; set; }
    }
}
