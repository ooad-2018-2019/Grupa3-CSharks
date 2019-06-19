using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeekAndFind.Models
{
    public class Fakultet: IKvalifikacija
    {
        public int FakultetId { get; set; }
        public string Naziv { get; set; }

        public bool equals(IKvalifikacija objekat)
        {
            if (!(objekat is Fakultet)) return false;
            Fakultet fakultet = (Fakultet)objekat;
            return this.Naziv.Equals(fakultet.Naziv);
        }
    }
}
