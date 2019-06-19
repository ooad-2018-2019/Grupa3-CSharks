using System;
using System.Collections.Generic;

namespace SeekAndFindWebServis
{
    public partial class RegistrovaniAplikanti
    {
        public int RegistrovaniAplikantiId { get; set; }
        public int KorisnikId { get; set; }
        public int OglasId { get; set; }

        public Korisnik Korisnik { get; set; }
        public Oglas Oglas { get; set; }
    }
}
