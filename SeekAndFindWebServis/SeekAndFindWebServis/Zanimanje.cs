using System;
using System.Collections.Generic;

namespace SeekAndFindWebServis
{
    public partial class Zanimanje
    {
        public Zanimanje()
        {
            RadnoIskustvo = new HashSet<RadnoIskustvo>();
        }

        public int ZanimanjeId { get; set; }
        public string Naziv { get; set; }

        public ICollection<RadnoIskustvo> RadnoIskustvo { get; set; }
    }
}
