using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Personas
    {
        bool actor, director, productor;
        string Nombre;
        string Apellido;
        string FechaN;
        string Biografia;
        public Personas(string n, string a, string f, string b, bool act, bool direc, bool prod)
        {
            Nombre = n;
            Apellido = a;
            FechaN = f;
            Biografia = b;
            actor = act;
            director = direc;
            productor = prod;
        }
    }

}
