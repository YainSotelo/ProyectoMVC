using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Otaku.MVC.Models;

namespace Otaku.Controllers
{
    public class GeneroController : Controller
    {
        [HttpGet]
        public IActionResult Index()
            => View(Repositorio.Generos);

        [HttpGet]
        public IActionResult Generos(int id)
        {
            var Genero = Repositorio.GetGenero(id);
            if (Genero is null)
            {
                return NotFound();
            }
            return View(Generos);
        }

        [HttpGet]
        public IActionResult FormAlta() => View();

        [HttpPost]
        public IActionResult FormAlta(Genero Genero)
        {
            Repositorio.AgregarGenero(Genero);
            return View("Index", Repositorio.Generos);
        }
    }
}