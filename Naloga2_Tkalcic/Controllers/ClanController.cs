using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Diagnostics.Telemetry;
using Microsoft.EntityFrameworkCore;
using Naloga2_Tkalcic.Models;
using Newtonsoft.Json;

namespace Naloga2_Tkalcic.Controllers
{
    public class ClanController : Controller
    {
        private readonly PodatkiContext baza;

        public ClanController(PodatkiContext baza)
        {
            this.baza = baza;
        }
        public async Task<IActionResult> Index()
        {
            var podatki = await baza.Uporabniki.ToListAsync();
            return View(podatki);
        }

        public async Task<IActionResult> Profil(string id)
        {
            var uporabnik = await baza.Uporabniki.FindAsync(id);
            if(uporabnik == null)
            {
                return NotFound();
            }

            return View(uporabnik);
        }

        public async Task<IActionResult> Narocanja(string id)
        {
            var client = new HttpClient();
            var apiUrl = "https://localhost:44319/api/Izposojas" + "/" + id;
            client.BaseAddress = new Uri(apiUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = client.GetAsync(apiUrl).Result;
            if (response.IsSuccessStatusCode)
            {
                var rezulatati = new List<Izposoja>();
                var convertedString = response.Content.ReadAsStringAsync();
                var izposoje = JsonConvert.DeserializeObject<List<Izposoja>>(convertedString.Result);
                foreach(var data in izposoje)
                {
                    var kljuc = int.Parse(data.FilmID);
                    var film = await baza.Filmi.FindAsync(kljuc);
                    data.Film = film;
                }
                return View(izposoje);
            }
            else
                return View(new List<Izposoja>());
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Izbrisi(string id)
        {
            var uporabnik = await baza.Uporabniki.FindAsync(id);
            if (uporabnik == null)
            {
                return NotFound();
            }

            baza.Uporabniki.Remove(uporabnik);
            await baza.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Uredi(string id)
        {
            var uporabnik = await baza.Uporabniki.FindAsync(id);
            if (uporabnik == null)
            {
                return NotFound();
            }
            return View(uporabnik);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public  async Task<IActionResult> Uredi(Uporabnik uporabnik)
        {
            using (baza)
            {
                var najdenUporabnik = baza.Uporabniki.First(x => x.Id == uporabnik.Id);
                najdenUporabnik.Ime = uporabnik.Ime;
                najdenUporabnik.Priimek = uporabnik.Priimek;
                najdenUporabnik.DatumRojstva = uporabnik.DatumRojstva;
                najdenUporabnik.EMSO = uporabnik.EMSO;
                najdenUporabnik.PostnaStevilka = uporabnik.PostnaStevilka;
                najdenUporabnik.Posta = uporabnik.Posta;
                najdenUporabnik.Drzava = uporabnik.Drzava;
                najdenUporabnik.EPosta = uporabnik.EPosta;
                najdenUporabnik.Starost = uporabnik.Starost;
                najdenUporabnik.KrajRojstva = uporabnik.KrajRojstva;
                baza.Uporabniki.Update(najdenUporabnik);
                await baza.SaveChangesAsync();
                
            }
            return RedirectToAction("Profil", new { id = uporabnik.Id });
        }
    }

    }

