using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Naloga2_Tkalcic.Models
{
    public class Login
    {
        [Required]
        [Display(Name = "E-Naslov")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Geslo")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
