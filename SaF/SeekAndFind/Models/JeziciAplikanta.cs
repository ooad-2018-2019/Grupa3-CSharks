using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SeekAndFind.Models
{
    public class JeziciAplikanta : IKvalifikacija
    {
        public int JeziciAplikantaId { get; set; }

        public int AplikantId { get; set; }

        [System.ComponentModel.DisplayName("Jezik ")]
        public int JezikId { get; set; }

        [DisplayName("Nivo čitanja")]
        [Range(1, 5)]
        public int NivoCitanja { get; set; }
        [DisplayName("Nivo pisanja")]
        [Range(1, 5)]
        public int NivoPisanja { get; set; }

        public virtual Aplikant Aplikant { get; set; }
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
