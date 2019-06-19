using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace SeekAndFind.Models
{
    public class SrednjaSkola: IKvalifikacija
    {
        [DisplayName("Srednja škola ")]
        public int SrednjaSkolaId { get; set; }
        public string Naziv { get; set; }
      

        public bool equals(IKvalifikacija objekat)
        {
            if (!(objekat is SrednjaSkola)) return false;
            SrednjaSkola srednjaSkola = (SrednjaSkola)objekat;
            return this.Naziv.Equals(srednjaSkola.Naziv);
        }
    }
}
