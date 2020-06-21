using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Naloga2_Tkalcic.Models;
using Newtonsoft.Json;

namespace Naloga2_Tkalcic.Controllers
{
    public class CartController : Controller
    {
        private readonly PodatkiContext baza;

        public CartController(PodatkiContext baza)
        {
            this.baza = baza;
        }
        public IActionResult Index()
        {
            return View(SessionData.izposojas);
        }

        public async Task<IActionResult> AddToCart(int id)
        {
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var claim = claimsIdentity.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier);
            var userId = claim.Value;
            var uporabnik = await baza.Uporabniki.FindAsync(userId);
            var film = await baza.Filmi.FindAsync(id);

            var izposoja = new Izposoja
            {
                Datum_Od = DateTime.Now,
                Datum_Do = DateTime.Now.AddDays(14),
                Cena = 5,
                UporabnikID = uporabnik.Id,
                FilmID = film.ID.ToString(),
                Uporabnik = uporabnik,
                Film = film
            };

            SessionData.izposojas.Add(izposoja);

            return RedirectToAction("Index", "Film");
        }

        public IActionResult Oddaj()
        {
            bool uspesnost = true;
            var client = new HttpClient();
            var apiUrl = "https://localhost:44319/api/Izposojas";
            client.BaseAddress = new Uri(apiUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            foreach (var data in SessionData.izposojas)
            {
                data.Film.ID = 0;
                var serielizedProduct = JsonConvert.SerializeObject(data);
                var content = new StringContent(serielizedProduct, Encoding.UTF8, "application/json");
                var response = client.PostAsync(apiUrl, content).Result;
                if (response.IsSuccessStatusCode)
                {
                    continue;
                }
                else
                {
                    uspesnost = false;
                    break;
                }
            }

            if (uspesnost == false)
            {
                return NotFound();
            }
            SessionData.izposojas.Clear();
            return RedirectToAction("Index", "Home");
        }

    }
}