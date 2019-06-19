using System;
using System.Collections.Generic;

namespace SeekAndFindWebServis
{
    public partial class Korisnik
    {
        public Korisnik()
        {
            FakultetiAplikanta = new HashSet<FakultetiAplikanta>();
            JeziciAplikanta = new HashSet<JeziciAplikanta>();
            Obavijest = new HashSet<Obavijest>();
            RadnoIskustvoAplikanta = new HashSet<RadnoIskustvoAplikanta>();
            RegistrovaniAplikanti = new HashSet<RegistrovaniAplikanti>();
            SrednjaSkolaAplikanta = new HashSet<SrednjaSkolaAplikanta>();
        }

        public int KorisnikId { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Grad { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Discriminator { get; set; }
        public string Sifra { get; set; }
        public string Detalji { get; set; }
        public string Naziv { get; set; }
        public string Oposlodavcu { get; set; }

        public ICollection<FakultetiAplikanta> FakultetiAplikanta { get; set; }
        public ICollection<JeziciAplikanta> JeziciAplikanta { get; set; }
        public ICollection<Obavijest> Obavijest { get; set; }
        public ICollection<RadnoIskustvoAplikanta> RadnoIskustvoAplikanta { get; set; }
        public ICollection<RegistrovaniAplikanti> RegistrovaniAplikanti { get; set; }
        public ICollection<SrednjaSkolaAplikanta> SrednjaSkolaAplikanta { get; set; }
    }
}
