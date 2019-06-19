using System;
using System.Collections.Generic;

namespace SeekAndFindWebServis
{
    public partial class Oglas
    {
        public Oglas()
        {
            FakultetiOglasa = new HashSet<FakultetiOglasa>();
            JeziciOglasa = new HashSet<JeziciOglasa>();
            Obavijest = new HashSet<Obavijest>();
            RegistrovaniAplikanti = new HashSet<RegistrovaniAplikanti>();
            SrednjaSkolaOglasa = new HashSet<SrednjaSkolaOglasa>();
        }

        public int OglasId { get; set; }
        public int ZanimanjeId { get; set; }
        public int PoslodavacId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public DateTime DatumObjavljivanja { get; set; }
        public DateTime DatumIsteka { get; set; }
        public bool Aktuelan { get; set; }
        public string Grad { get; set; }

        public ICollection<FakultetiOglasa> FakultetiOglasa { get; set; }
        public ICollection<JeziciOglasa> JeziciOglasa { get; set; }
        public ICollection<Obavijest> Obavijest { get; set; }
        public ICollection<RegistrovaniAplikanti> RegistrovaniAplikanti { get; set; }
        public ICollection<SrednjaSkolaOglasa> SrednjaSkolaOglasa { get; set; }
    }
}
