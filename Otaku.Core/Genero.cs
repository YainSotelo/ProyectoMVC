using System;
using System.Collections.Generic;

namespace Otaku.Core
{
    public class Genero
    {
        private List<Anime> Anime;
        public int Id { get; set; }

        public string Nombre { get; set; }

        public Genero()
        {
            Anime = new List<Anime>();
        }

        public void AgregarAnime(Anime animes)
            => Anime.Add(animes);
    }
}
