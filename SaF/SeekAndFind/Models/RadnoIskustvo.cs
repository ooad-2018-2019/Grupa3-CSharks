using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SeekAndFind.Models
{
    public class RadnoIskustvo
    {
        public int RadnoIskustvoId { get; set; }

        [DisplayName("Zanimanje")]
        public int ZanimanjeId { get; set; }
        public string Kompanija { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Datum početka")]
        public DateTime? DatumPocetka { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Datum kraja")]
        public DateTime? DatumKraja { get; set; }
        public virtual Zanimanje Zanimanje { get; set; }


    }
}
