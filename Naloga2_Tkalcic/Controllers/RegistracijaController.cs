using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Naloga2_Tkalcic.Models;
using Newtonsoft.Json;

namespace Naloga2_Tkalcic.Controllers
{
    public class RegistracijaController : Controller
    {
        private UserManager<Uporabnik> UserManager { get; }
        private SignInManager<Uporabnik> SignInManager { get; }

        public RegistracijaController(UserManager<Uporabnik> userManager, SignInManager<Uporabnik> signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var uporabnik = new UporabnikZgesli();
            return View(uporabnik);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(UporabnikZgesli uporabnik)
        {
            if (ModelState.IsValid)
            {
                /*
                TempData["Ime"] = uporabnik.Ime;
                TempData["Priimek"] = uporabnik.Priimek;
                TempData["Datum"] = uporabnik.DatumRojstva;
                TempData["Emso"] = uporabnik.EMSO;
                TempData["Starost"] = uporabnik.Starost;
                TempData["KrajRojstva"] = uporabnik.KrajRojstva;
                TempData["Naslov"] = uporabnik.Naslov;
                TempData["PostnaStevilka"] = uporabnik.PostnaStevilka;
                TempData["Posta"] = uporabnik.Posta;
                TempData["Drzava"] = uporabnik.Drzava;
                TempData["EPosta"] = uporabnik.EPosta;
                //TempData["Geslo"] = uporabnik.Geslo;
                //TempData["GesloDva"] = uporabnik.PonovnoGeslo;
                */
                uporabnik.UserName = uporabnik.EPosta;
                

                var uporabnikString = JsonConvert.SerializeObject(uporabnik);

                var rezultat = await UserManager.CreateAsync(uporabnik, uporabnik.Geslo);
                if (rezultat.Succeeded)
                {
                    await UserManager.AddToRoleAsync(uporabnik, "User");
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach(var data in rezultat.Errors)
                    {
                        ModelState.AddModelError("", data.Description);
                    }
                }
                /*
                using (var kontekst = new PodatkiContext())
                {
                   // kontekst.Uporabniki.Add(uporabnik);
                    kontekst.SaveChanges();
                }
                */

                return RedirectToAction("ZadnjiKorak", uporabnik);
            }
            else
            {
                return View();
            }
        }


        /*
        [HttpPost]
        public IActionResult Index(string Ime, string Priimek, DateTime Datum, int Emso, int Starost)
        {
            if(Ime == null || Priimek == null || Datum == null || Emso == 0 || Starost == 0)
            {
                return View();
            }

            TempData["Ime"] = Ime;
            TempData["Priimek"] = Priimek;
            TempData["Datum"] = Datum;
            TempData["Emso"] = Emso;
            TempData["Starost"] = Starost;
            TempData["Stevec"] = true;

            return RedirectToAction("DrugiKorak");
        }
        */

        public IActionResult DrugiKorak()
        {
            if (TempData["Stevec"] == null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public IActionResult DrugiKorak(string Naslov, int Postna, string Posta, string Drzava)
        {

            if (Naslov == null || Postna == 0 || Posta == null || Drzava == null)
            {
                return View();
            }

            TempData["Naslov"] = Naslov;
            TempData["PostnaStevilka"] = Postna;
            TempData["Posta"] = Posta;
            TempData["Drzava"] = Drzava;
            TempData["Stevec"] = true;

            return RedirectToAction("TretjiKorak");
        }

        public IActionResult TretjiKorak()
        {
            if (TempData["Stevec"] == null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public IActionResult TretjiKorak(string EPosta, string Geslo, string GesloDva)
        {
            if (EPosta == null || Geslo == null || GesloDva == null)
            {
                return View();
            }

            TempData["EPosta"] = EPosta;
            TempData["Geslo"] = Geslo;
            TempData["GesloDva"] = GesloDva;
            TempData["Stevec"] = true;

            return RedirectToAction("ZadnjiKorak");
        }

        public IActionResult ZadnjiKorak()
        {
            return View();
        }
    }
}