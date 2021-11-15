using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Otaku.MVC.Models;
using Otaku.Core;

namespace Otaku.Controllers
{
    public class AnimeController : Controller
    {
        
        [HttpGet]
        public IActionResult Index()
            => View(Repositorio.Animes);

        [HttpGet]
        public IActionResult Animes(int id)
        {
            var anime = Repositorio.GetAnime(id);
            if (anime is null)
            {
                return NotFound();
            }
            return View(anime);
        }

        [HttpGet]
        public IActionResult FormAlta() => View();

        [HttpPost]
        public IActionResult FormAlta(Anime anime)
        {
            Repositorio.AgregarAnime(anime);
            return View("Index", Repositorio.Animes);
        }
    }
}

