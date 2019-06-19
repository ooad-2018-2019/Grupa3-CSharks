using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeekAndFind.Models
{
    public class Zanimanje : IKvalifikacija
    {
        public int ZanimanjeId { get; set; }
        public string Naziv { get; set; }

        public bool equals(IKvalifikacija objekat)
        {
            if (!(objekat is Zanimanje)) return false;
            Zanimanje zanimanje = (Zanimanje)objekat;
            return this.Naziv.Equals(zanimanje.Naziv);
        }
    }
}
