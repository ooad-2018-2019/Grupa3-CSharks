using System;
using System.Collections.Generic;

namespace SeekAndFindWebServis
{
    public partial class RadnoIskustvo
    {
        public RadnoIskustvo()
        {
            RadnoIskustvoAplikanta = new HashSet<RadnoIskustvoAplikanta>();
        }

        public int RadnoIskustvoId { get; set; }
        public int ZanimanjeId { get; set; }
        public string Kompanija { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumKraja { get; set; }

        public Zanimanje Zanimanje { get; set; }
        public ICollection<RadnoIskustvoAplikanta> RadnoIskustvoAplikanta { get; set; }
    }
}
