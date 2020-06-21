using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Naloga2_Tkalcic.Models
{
    public class Film
    {
        [HiddenInput(DisplayValue = false)]
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Prosim izpolnite obvezno polje")]
        [Display(Name = "Ime Filma")]
        public string Naziv { get; set; }
        [Required(ErrorMessage = "Prosim izpolnite obvezno polje")]
        [RegularExpression(@"^[a-zA-Z_\u00A1-\uFFFF]+$", ErrorMessage = "Prosimo uporabite samo črke")]
        [Display(Name = "Zvrst Filma")]
        public string Zanr { get; set; }
        [Required(ErrorMessage = "Prosim izpolnite obvezno polje")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Prosim vstavite samo številke")]
        [Display(Name = "Dolžina Filma")]
        public int Dolzina { get; set; }
        [Required(ErrorMessage = "Prosim izpolnite obvezno polje")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Prosim vstavite samo številke")]
        [Display(Name = "Število Izvodov")]
        public int St_Izvodov { get; set; }
    }
}
