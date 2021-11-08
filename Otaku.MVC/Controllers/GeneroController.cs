using Microsoft.AspNetCore.Mvc;
using Otaku.Core;

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