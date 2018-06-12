using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class PeliculaProductor
    {
        Peliculas pelicula;
        Personas Productor;
        public PeliculaProductor(Peliculas peli, Personas Prod)
        {
            pelicula = peli;
            Productor = Prod;
        }
    }
}
