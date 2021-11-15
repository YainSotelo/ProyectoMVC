using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Otaku.Core;


namespace Otaku.Core
{
    public static class Repositorio
    {
        static int idGenero = 1;
        static int idAnime = 1;
        static int idCapitulos = 1;

        #region Capitulo
        static readonly List<Capitulo> capitulos = new List<Capitulo>();
        public static IEnumerable<Capitulo> Capitulos
        => Capitulos;
          public static void AgregarCapitulo(Capitulo Capitulo)
        {
            Capitulo.Id = idCapitulos++;
            Capitulo.Add(Capitulo);
        }

        public static object GetProducto(int id)
        {
            throw new NotImplementedException();
        }

        public static Capitulo GetCapitulo(int Id)
            => capitulos.Find(c =>c.Id == Id);
        #endregion

        #region Genero

        static readonly List<Genero> generos = new List<Genero>();
         public static IEnumerable<Genero> Generos;
        public static void AgregarGenero(Genero Genero)
        {
            Genero.Id = idGenero++;
            generos.Add(Genero);
        }
        public static Genero GetGenero(int id)
           => generos.Find(g => g.Id == id);

        #endregion

        #region Anime
        static readonly List<Anime> animes = new List<Anime>();
         public static IEnumerable<Anime> Animes;
        public static void AgregarAnime(Anime Animes)
        {
            Anime.id = idAnime++;
            Anime.Add(Animes);
        }
        public static Anime GetAnime(int id)
           => animes.Find(a => a.Id == id);


        #endregion
    }
}