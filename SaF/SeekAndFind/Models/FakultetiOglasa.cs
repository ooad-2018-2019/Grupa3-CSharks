using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeekAndFind.Models
{
    public class FakultetiOglasa
    {
        public string FakultetiOglasaId { get; set; }     
        public int FakultetId { get; set; }
        public int OglasId { get; set; }

        public virtual Fakultet Fakultet { get; set; }
        public virtual Oglas Oglas  { get; set; }


    }
}
