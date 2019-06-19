using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeekAndFind.Models
{
    public class JeziciOglasa
    {
        public int JeziciOglasaId { get; set; }

        public int OglasId { get; set; }

        public int JezikId { get; set; }

        public int NivoCitanja { get; set; }
        public int NivoPisanja { get; set; }

        public virtual Oglas Oglas { get; set; }
        public virtual Jezik Jezik { get; set; }

        public bool equals(IKvalifikacija objekat)
        {
            if (!(objekat is JeziciAplikanta)) return false;
            JeziciAplikanta jezik = (JeziciAplikanta)objekat;
            if (!(this.Jezik.equals(jezik.Jezik))) return false;

            if (this.NivoCitanja >= jezik.NivoCitanja && this.NivoPisanja >= jezik.NivoPisanja) return true;

            return false;
        }

    }
}
