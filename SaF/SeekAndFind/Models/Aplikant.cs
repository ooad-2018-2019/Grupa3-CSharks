using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SeekAndFind.Models
{
    public class Aplikant : Korisnik
    {
        

        public string Ime { get; set; }
        public string Prezime { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Datum rođenja")]
        public DateTime? DatumRodjenja { get; set; }

        public virtual ICollection<FakultetiAplikanta> FakultetiAplikanta { get; set; }
        public virtual ICollection<SrednjaSkolaAplikanta> SrednjaSkolaAplikanta { get; set; }
        public virtual ICollection<JeziciAplikanta> JeziciAplikanta { get; set; }

        public virtual ICollection<Obavijest> Obavijesti { get; set; }

    }
}
