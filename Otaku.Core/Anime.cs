using System;
using System.Collections.Generic;

namespace Otaku.Core
{
    public class Anime
    {
        internal static int id;

        public int Id { get; set; }

        public string Nombre { get; set; }

        public Genero Genero { get; set; }

        public string Descripcion{get; set;}

        public Anime(){}

        public void AgregarCapitulo(Capitulo capitulo)
            => Capitulo.Add(capitulo);

        internal static void Add(Anime animes)
        {
            throw new NotImplementedException();
        }
    }
}
