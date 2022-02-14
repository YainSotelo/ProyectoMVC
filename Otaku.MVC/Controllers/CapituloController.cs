using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Otaku.MVC.ViewModels;
using Otaku.MVC.Models;
using Otaku.Core;

namespace Otaku.MVC.Controllers
{
    public class CapituloController : Controller
    {
        [HttpGet]
        public IActionResult Index()
            => View(Repositorio.Capitulos);

        [HttpGet]
        public IActionResult Capitulos(int id)
        {
            var Capitulo = Repositorio.GetCapitulo(id);
            if (Capitulo is null)
            {
                return NotFound();
            }
            return View(Capitulo);
        }

        [HttpGet]
        public IActionResult FormAlta() => View();

        [HttpPost]
        public IActionResult FormAlta(Capitulo Capitulo)
        {
            Repositorio.AgregarCapitulo(Capitulo);
            return View("Index", Repositorio.Capitulos);
        }
    }
}