using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    [Serializable]
    public class PeliculaProductor
    {
        Peliculas pelicula;
        Personas Productor;
        public PeliculaProductor(Peliculas peli, Personas Prod)
        {
            pelicula = peli;
            Productor = Prod;
        }
        public Peliculas getPelicula()
        {
            return this.pelicula;
        }
        public Personas getProductor()
        {
            return this.Productor;
        }
    }
}
