using System;
using System.Collections.Generic;

namespace SeekAndFindWebServis
{
    public partial class JeziciOglasa
    {
        public int JeziciOglasaId { get; set; }
        public int OglasId { get; set; }
        public int JezikId { get; set; }
        public int NivoCitanja { get; set; }
        public int NivoPisanja { get; set; }

        public Jezik Jezik { get; set; }
        public Oglas Oglas { get; set; }
    }
}
