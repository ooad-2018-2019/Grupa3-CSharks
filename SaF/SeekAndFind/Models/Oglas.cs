using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SeekAndFind.Models
{
    public class Oglas
    {
        public int OglasId { get; set; }
        public int ZanimanjeId { get; set; }
        public int PoslodavacId { get; set; }
        [Required]
        public string Naziv { get; set; }

        [Required]
        public string Opis { get; set; }

        [Required]
        [DisplayName("Datum objavljivanja")]
        [DataType(DataType.Date)]
        public DateTime? DatumObjavljivanja { get; set; }
        [DisplayName("Datum isteka")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime? DatumIsteka { get; set; }

        public bool Aktuelan { get; set; }
        public string Grad { get; set; }

        public virtual Zanimanje Zanimanje { get; set; }
        public virtual Poslodavac Poslodavac { get; set; }

        public virtual ICollection<FakultetiOglasa> FakultetiOglasa { get; set; }
        public virtual ICollection<SrednjaSkolaOglasa> SrednjaSkolaOglasa { get; set; }
        public virtual ICollection<JeziciOglasa> JeziciOglasa { get; set; }

        public virtual ICollection<RegistrovaniAplikanti> RegistrovaniAplikanti { get; set; }

        public static implicit operator Oglas(Task<Oglas> v)
        {
            throw new NotImplementedException();
        }
    }
}
