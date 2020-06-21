using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Naloga2_Tkalcic.Models
{
    public enum clanarina { Da, Ne }
    public class Clan
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Priimek { get; set; }
        public int Starost { get; set; }
        public clanarina Clanarina { get; set; }
    }
}