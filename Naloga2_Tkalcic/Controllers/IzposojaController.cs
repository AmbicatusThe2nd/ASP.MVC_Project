using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Naloga2_Tkalcic.Models;

namespace Naloga2_Tkalcic.Controllers
{
    public class IzposojaController : Controller
    {
        private readonly PodatkiContext baza;

        public IzposojaController(PodatkiContext baza)
        {
            this.baza = baza;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}