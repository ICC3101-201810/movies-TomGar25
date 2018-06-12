using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class PeliculaActor
    {
        Peliculas pelicula;
        Personas actor;
        public PeliculaActor(Peliculas peli, Personas act)
        {
            pelicula = peli;
            actor = act;
        }
    }
}
