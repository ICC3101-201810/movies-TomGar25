using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Peliculas
    {
        string Nombre, Fecha_Estreno, Descripcion, Presupuesto, Estudio;
        string director;
        public Peliculas(string n,string d ,string f, string des, string pre, string es)
        {
            Nombre = n;
            director = d;
            Fecha_Estreno = f;
            Descripcion = des;
            Presupuesto = pre;
            Estudio = es;
        }

    }
}
