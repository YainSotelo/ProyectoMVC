using System;
using System.Collections.Generic;

namespace Otaku.Core
{
    public class Anime
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public List<Anime> Animes { get; set; }

        public Genero Genero { get; set; }

        public Anime()
        {
            Animes = new List<Anime>();
        }

        public void AgregarCapitulo(Capitulo capitulo)
            => Capitulo.Add(capitulo);

    
    }
}
