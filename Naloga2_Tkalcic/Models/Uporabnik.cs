using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Naloga2_Tkalcic.CustomValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Naloga2_Tkalcic.Models
{
    public class Uporabnik : IdentityUser
    {
        
        [HiddenInput(DisplayValue = false)]
        [Key]
        public int IDUporabnik { get; set; }
        
        [Required(ErrorMessage = "Prosim izpolnite obvezno polje")]
        [RegularExpression(@"^[a-zA-Z_\u00A1-\uFFFF]+$", ErrorMessage = "Prosimo uporabite samo črke")]
        [Display(Name = "Ime")]
        public string Ime { get; set; }
        [Required(ErrorMessage = "Prosim izpolnite obvezno polje")]
        [RegularExpression(@"^[a-zA-Z_\u00A1-\uFFFF]+$", ErrorMessage = "Prosimo uporabite samo črke")]
        [Display(Name = "Priimek")]
        public string Priimek { get; set; }
        [Required(ErrorMessage = "Prosim izpolnite obvezno polje")]
        [Display(Name = "Datum Rojstva")]
        [Range(typeof(DateTime), "1900/1/1", "2020/3/23", ErrorMessage = "Prosimo uporabite med {1} in {2}")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DatumRojstva { get; set; }
        [Required(ErrorMessage = "Prosim izpolnite obvezno polje")]
        [RegularExpression(@"^[0-9\s]{13,13}$", ErrorMessage = "Emšo mora imeti 13 zaporednih števil")]
        [EmsoValidation]
        [Display(Name = "Emšo")]
        public string EMSO { get; set; }
        [Required(ErrorMessage = "Prosim izpolnite obvezno polje")]
        [Display(Name = "Starost")]
        public int? Starost { get; set; }
        [Required(ErrorMessage = "Prosim izpolnite obvezno polje")]
        [Display(Name = "Kraj Rojstva")]
        public string KrajRojstva { get; set; }
        [Required(ErrorMessage = "Prosim izpolnite obvezno polje")]
        [Display(Name = "Naslov")]
        public string Naslov { get; set; }
        [Required(ErrorMessage = "Prosim izpolnite obvezno polje")]
        [Display(Name = "Poštna Številka")]
        public int? PostnaStevilka { get; set; }
        [Required(ErrorMessage = "Prosim izpolnite obvezno polje")]
        [Display(Name = "Pošta")]
        public string Posta { get; set; }
        [Required(ErrorMessage = "Prosim izpolnite obvezno polje")]
        [Display(Name = "Država")]
        public string Drzava { get; set; }
        [Required(ErrorMessage = "Prosim izpolnite obvezno polje")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z_\u00A1-\uFFFF]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z_\u00A1-\uFFFF])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z_\u00A1-\uFFFF][-0-9a-z_\u00A1-\uFFFF]*[0-9a-z_\u00A1-\uFFFF]*\.)+[a-z0-9_\u00A1-\uFFFF][\-a-z0-9_\u00A1-\uFFFF]{0,22}[a-z0-9_\u00A1-\uFFFF]))$",
            ErrorMessage = "Prosim vnesite pravi E-naslov.")]
        [Display(Name = "E-Naslov")]
        public string EPosta { get; set; }
       

        
        public static IEnumerable<SelectListItem> GetItems()
        {
            yield return new SelectListItem { Text = "Ljubljana", Value = "lj", Selected = true };
            yield return new SelectListItem { Text = "Maribor", Value = "mb" };
            yield return new SelectListItem { Text = "Celje", Value = "ce" };
            yield return new SelectListItem { Text = "Koper", Value = "kp" };
            yield return new SelectListItem { Text = "Murksa Sobota", Value = "ms" };
        }
        
    }
}
