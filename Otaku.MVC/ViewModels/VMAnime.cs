using Otaku.Core;
using System.Collections.Generic;

namespace Otaku.MVC.ViewModels
{
   
    public class VMAnime
    {
        public IEnumerable<Genero> generos { get; set; }

        public Anime Anime { get; set; }

        public int? IdGeneroSeleccionado { get; set; }

        public VMAnime() => Anime= new Anime();

        public VMAnime(IEnumerable<Genero> Generos) : this()

            => generos = Generos;

        public VMAnime(Anime Anime)
        {
            Anime = this.Anime;            
        }
    }
}