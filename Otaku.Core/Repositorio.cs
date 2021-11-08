using System.Collections.Generic;
using System.Linq;
using System;

namespace Otaku.Core
{
    public static class Repositorio
    {
        static int idGenero = 1;
        static int idAnime = 1;
        static int idCapitulos = 1;

        #region Capitulo
        static readonly List<Capitulo> Capitulos = new List<Capitulo>();
        public static IEnumerable<Capitulo> Capitulos
        => Capitulos;
        public static Capitulo GetCapitulo(int id)
            => Capitulo.Find(c => c.Id == id);
        public static void AgregarCapitulo(Capitulo Capitulo)
        {
            Capitulo.Id = idCapitulos++;
            Capitulo.Add(Capitulo);
        }
        #endregion

        #region Genero

        static readonly List<Genero> Generos = new List<Genero>();
         public static IEnumerable<Genero> Generos
        public static void AgregarGenero(Genero Genero)
        {
            Genero.Id = idGenero++;
            Generos.Add(Genero);
        }
        public static Genero GetGenero(int id)
           => Generos.Find(g => g.id == id);

        #endregion

        #region Anime
        static readonly List<Anime> Animes = new List<Anime>();
         public static IEnumerable<Anime> Animes
        public static void AgregarAnime(Anime Animes)
        {
            Anime.Id = idAnime++;
            Animes.Add(Anime);
        }
        public static Anime GetAnime(int id)
           => Animes.Find(a => a.id == id);


        #endregion
    }
}