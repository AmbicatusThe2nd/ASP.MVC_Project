using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Naloga2_Tkalcic.Models;

namespace Naloga2_Tkalcic.Controllers
{
    public class FilmController : Controller
    {
        private readonly PodatkiContext baza;

        public FilmController(PodatkiContext baza)
        {
            this.baza = baza;
        }
        public async Task<IActionResult> Index()
        {
            var podatki = await baza.Filmi.ToListAsync();
            return View(podatki);
        }

        public IActionResult Dodaj()
        {
            var film = new Film();
            return View(film);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Dodaj(Film film)
        {
            try
            {
                baza.Filmi.Add(film);
                await baza.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            catch
            {
                return BadRequest();
            }
        }

        public IActionResult ZadnjiKorak()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Izbrisi(int id)
        {
            try
            {
                var film = await baza.Filmi.FindAsync(id);
                if (film == null)
                {
                    return NotFound();
                }

                baza.Filmi.Remove(film);
                await baza.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Uredi(int id)
        {
            var Film = await baza.Filmi.FindAsync(id);
            if (Film == null)
            {
                return NotFound();
            }
            return View(Film);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Uredi(Film film)
        {
            using(baza)
            {
                var najdenFilm = baza.Filmi.First(x => x.ID == film.ID);
                najdenFilm.Naziv = film.Naziv;
                najdenFilm.Dolzina = film.Dolzina;
                najdenFilm.Zanr = film.Zanr;
                najdenFilm.St_Izvodov = film.St_Izvodov;
                baza.Filmi.Update(najdenFilm);
                baza.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        public async Task<IActionResult> Podrobnosti(int id)
        {
            if(id == 0)
            {
                return RedirectToAction("Index");
            }
            try
            {
                var film = await baza.Filmi.FindAsync(id);
                return View(film);
            }
            catch
            {
                return NotFound();
            }
        }
    }
}