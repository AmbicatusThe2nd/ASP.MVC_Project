using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Naloga2_Tkalcic.Models
{
    public class Izposoja
    {
        [Key]
        public int ID { get; set; }
        public DateTime Datum_Od { get; set; }
        public DateTime Datum_Do { get; set; }
        public double Cena { get; set; }
        public Uporabnik Clan { get; set; }
        public Film Film { get; set; }
    }
}
