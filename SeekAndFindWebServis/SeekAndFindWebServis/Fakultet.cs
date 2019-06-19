using System;
using System.Collections.Generic;

namespace SeekAndFindWebServis
{
    public partial class Fakultet
    {
        public Fakultet()
        {
            FakultetiAplikanta = new HashSet<FakultetiAplikanta>();
            FakultetiOglasa = new HashSet<FakultetiOglasa>();
        }

        public int FakultetId { get; set; }
        public string Naziv { get; set; }

        public ICollection<FakultetiAplikanta> FakultetiAplikanta { get; set; }
        public ICollection<FakultetiOglasa> FakultetiOglasa { get; set; }
    }
}
