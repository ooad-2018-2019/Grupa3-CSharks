using System;
using System.Collections.Generic;

namespace SeekAndFindWebServis
{
    public partial class Jezik
    {
        public Jezik()
        {
            JeziciAplikanta = new HashSet<JeziciAplikanta>();
            JeziciOglasa = new HashSet<JeziciOglasa>();
        }

        public int JezikId { get; set; }
        public string Naziv { get; set; }

        public ICollection<JeziciAplikanta> JeziciAplikanta { get; set; }
        public ICollection<JeziciOglasa> JeziciOglasa { get; set; }
    }
}
