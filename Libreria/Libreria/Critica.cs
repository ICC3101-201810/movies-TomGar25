using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    class Critica
    {
        public Peliculas peli;
        public string emisor, mensaje;
        public Critica(string e, string m, Peliculas pe)
        {
            emisor = e;
            mensaje = m;
            peli = pe;

        }
    }
}
