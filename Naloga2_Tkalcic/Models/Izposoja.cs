using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Naloga2_Tkalcic.Models
{
    public class Izposoja
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Datum izposoje")]
        public DateTime Datum_Od { get; set; }
        [Display(Name = "Predviden datum vrtnitve")]
        public DateTime Datum_Do { get; set; }
        public double Cena { get; set; }
        public string FilmID { get; set; }
        public string UporabnikID { get; set; }
        public virtual Uporabnik Uporabnik { get; set; }
        public virtual  Film Film { get; set; }
    }
}
