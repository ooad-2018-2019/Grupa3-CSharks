using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeekAndFind.Models.ViewModels
{
    public class DodijeljeniJeziciOglasu
    {
        public int JezikId{ get; set; }
        public string Naziv { get; set; }
        public int NivoCitanja { get; set; }
        public int NivoPisanja { get; set; }
        public bool Assigned { get; set; }
    }
}
