using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace SeekAndFind.Models
{
    public class Jezik : IKvalifikacija
    {
        [DisplayName("Jezik ")]
        public int JezikId { get; set; }
        public string Naziv { get; set; }

        public bool equals(IKvalifikacija objekat)
        {
            if (!(objekat is Jezik)) return false;
            Jezik jezik = (Jezik)objekat;
            return this.Naziv.Equals(jezik.Naziv);
        }

    }
}
