using System;
using System.Collections.Generic;

namespace Otaku.Core
{
    public class Anime
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public Genero Genero { get; set; }

        public string Descripcion{get; set;}

        public Anime()
        {
            anime = new List<Anime>();
        }

        public void AgregarCapitulo(Capitulo capitulo)
            => Capitulo.Add(capitulo);

        internal void Add(Anime animes)
        {
            throw new NotImplementedException();
        }

    }
}
