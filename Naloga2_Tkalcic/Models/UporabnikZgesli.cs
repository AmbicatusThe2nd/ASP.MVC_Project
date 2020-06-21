using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Naloga2_Tkalcic.Models
{
    [NotMapped]
    public class UporabnikZgesli : Uporabnik
    {
        [Required(ErrorMessage = "Prosim izpolnite obvezno polje")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{5,}$", ErrorMessage = "Geslo mora vsebovati vsaj eno število in poseben znak")]
        [DataType(DataType.Password)]
        [Display(Name = "Geslo")]
        public string Geslo { get; set; }
        [Required(ErrorMessage = "Prosim izpolnite obvezno polje")]
        [Compare("Geslo", ErrorMessage = "Gesli se ne ujemata")]
        [DataType(DataType.Password)]
        [Display(Name = "Ponovitev Gesla")]
        public string PonovnoGeslo { get; set; }
    }
}
