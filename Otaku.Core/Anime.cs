using System;

namespace Otaku.Core
{
    public class Anime
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Anime> Animes { get; set; }
        public string Genero {  get; set;  }

        public Anime()
        {
            Animes = new List<Anime>();
        }

        public void AgregarAnime(Anime animes)
            => Anime.Add(animes);



        
    }
}
