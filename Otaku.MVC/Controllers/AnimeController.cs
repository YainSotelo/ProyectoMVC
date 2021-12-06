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
        public IActionResult FormAlta(Anime anime)
        {
            Repositorio.AgregarAnime(anime);
            return View("Index", Repositorio.Animes);
        }
        
        [HttpPost]
        public IActionResult FormAlta(VMAnime vMAnime)
        {
            var genero = Repositorio.GetGenero(vMAnime.IdGeneroSeleccionado.Value);
                genero.AgregarAnime(vMAnime.Anime);
                Repositorio.AgregarAnime(vMAnime.Anime);

                return View("Index", Repositorio.Animes);
        }   
    }
}

