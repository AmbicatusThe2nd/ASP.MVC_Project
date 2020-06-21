using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Naloga2_Tkalcic.CustomValidation
{
    public class EmsoValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object sentValue, ValidationContext vc)
        {
            try
            {
                var emso = sentValue.ToString();
                var dobljeneCifre = new List<int>();
                for (int i = 0; i <= 12; i++)
                {
                    int cifra = 0;
                    switch (i)
                    {
                        case 0:
                            cifra = Convert.ToInt32(emso[i].ToString()) * 7;
                            dobljeneCifre.Add(cifra);
                            break;
                        case 1:
                            cifra = Convert.ToInt32(emso[i].ToString()) * 6;
                            dobljeneCifre.Add(cifra);
                            break;
                        case 2:
                            cifra = Convert.ToInt32(emso[i].ToString()) * 5;
                            dobljeneCifre.Add(cifra);
                            break;
                        case 3:
                            cifra = Convert.ToInt32(emso[i].ToString()) * 4;
                            dobljeneCifre.Add(cifra);
                            break;
                        case 4:
                            cifra = Convert.ToInt32(emso[i].ToString()) * 3;
                            dobljeneCifre.Add(cifra);
                            break;
                        case 5:
                            cifra = Convert.ToInt32(emso[i].ToString()) * 2;
                            dobljeneCifre.Add(cifra);
                            break;
                        case 6:
                            cifra = Convert.ToInt32(emso[i].ToString()) * 7;
                            dobljeneCifre.Add(cifra);
                            break;
                        case 7:
                            cifra = Convert.ToInt32(emso[i].ToString()) * 6;
                            dobljeneCifre.Add(cifra);
                            break;
                        case 8:
                            cifra = Convert.ToInt32(emso[i].ToString()) * 5;
                            dobljeneCifre.Add(cifra);
                            break;
                        case 9:
                            cifra = Convert.ToInt32(emso[i].ToString()) * 4;
                            dobljeneCifre.Add(cifra);
                            break;
                        case 10:
                            cifra = Convert.ToInt32(emso[i].ToString()) * 3;
                            dobljeneCifre.Add(cifra);
                            break;
                        case 11:
                            cifra = Convert.ToInt32(emso[i].ToString()) * 2;
                            dobljeneCifre.Add(cifra);
                            break;
                    }
                }

                int sestevek = dobljeneCifre.Sum();
                int ostanek = sestevek % 11;
                int kontrolnaStevilka = 11 - ostanek;
                if (kontrolnaStevilka == Convert.ToInt32(emso[12].ToString()))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Vpiši korekten emšo");
                }
            }
            catch
            {
                return new ValidationResult("Vpiši korekten emšo");
            }
            
        }
    }
}
