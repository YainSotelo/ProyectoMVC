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
        static readonly List<Capitulo> Capitulo = new List<Capitulo>();
        #region Capitulo
        public static IEnumerable<Capitulo> capitulos
        => capitulos;
        public static Capitulo GetCapitulo(int id)
            => Capitulo.Find(c => c.Id == id);
        public static void AgregarCapitulo(Capitulo capitulo)
        {
            capitulo.Id = idCapitulos++;
            Capitulo.Add(capitulo);
        }
        #endregion

        #region Genero

        static readonly List<Genero> generos = new List<Genero>();
        public static void AgregarGenero(Genero genero)
        {
            genero.Id = idGenero++;
            generos.Add(genero);
        }
        public static Genero GetGenero(int id)
           => generos.Find(g => g.id == id);

        #endregion

        #region Anime
        static readonly List<Anime> animes = new List<Anime>();

        #endregion
    }
}