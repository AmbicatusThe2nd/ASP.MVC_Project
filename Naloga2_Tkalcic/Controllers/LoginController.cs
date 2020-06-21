using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Naloga2_Tkalcic.Models;

namespace Naloga2_Tkalcic.Controllers
{
    public class LoginController : Controller
    {
        private UserManager<Uporabnik> UserManager { get; }
        private SignInManager<Uporabnik> SignInManager { get; }

        public LoginController(UserManager<Uporabnik> userManager, SignInManager<Uporabnik> signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }
        public IActionResult Index()
        {
            var login = new Login();
            return View(login);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(Login login)
        {
            if (ModelState.IsValid)
            {
                var uporabnik = await UserManager.FindByNameAsync(login.UserName);
                if(uporabnik != null)
                {
                    await SignInManager.SignOutAsync();
                    Microsoft.AspNetCore.Identity.SignInResult signInResult = await SignInManager.PasswordSignInAsync(uporabnik, login.Password, false, false);
                    if (signInResult.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                ModelState.AddModelError(nameof(login.UserName), "Prijava ni bila uspešna, preverite podatke in poiskusite še enkrat");
            }
            return View(login);
        }

        [AllowAnonymous]
        public IActionResult GoogleLogin()
        {
            var pricakovanUrl = Url.Action("GoogleResponse", "Login");
            var nastaviteve = SignInManager.ConfigureExternalAuthenticationProperties("Google", pricakovanUrl);
            return Challenge(nastaviteve, "Google");
        }

        [HttpGet]
        public async Task<IActionResult> GoogleResponse()
        {
            var info = await SignInManager.GetExternalLoginInfoAsync();
            if(info == null)
            {
                return RedirectToAction("Index");
            }

            var rezultat = SignInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, false);
            var uporabnikPodatki = new string[] { info.Principal.FindFirst(ClaimTypes.Name).Value, info.Principal.FindFirst(ClaimTypes.Email).Value };
            if (rezultat.IsCompletedSuccessfully)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                var uporabnik = new Uporabnik
                {
                    Ime = info.Principal.FindFirst(ClaimTypes.GivenName).Value,
                    Priimek = info.Principal.FindFirst(ClaimTypes.Surname).Value,
                    DatumRojstva = new DateTime(1999,6,11),
                    Starost = 26,
                    EMSO = "1111111111111",
                    KrajRojstva = "Google user",
                    Posta = "Google user",
                    PostnaStevilka = 2000,
                    Drzava = "Slovenia",
                    EPosta = info.Principal.FindFirst(ClaimTypes.Email).Value,
                    UserName = info.Principal.FindFirst(ClaimTypes.Email).Value,
                    Email = info.Principal.FindFirst(ClaimTypes.Email).Value
                };

                try
                {
                    var create = await UserManager.CreateAsync(uporabnik);
                    if (create.Succeeded)
                    {
                        await UserManager.AddToRoleAsync(uporabnik, "User");
                        return RedirectToAction("Index", "Home");
                    }
                    return RedirectToAction("Index", "Home");
                }
                catch
                {
                    return RedirectToAction("Index", "Home");
                }
            }

        }

        public async Task<IActionResult> Logout()
        {
            await SignInManager.SignOutAsync();
            SessionData.izposojas.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}