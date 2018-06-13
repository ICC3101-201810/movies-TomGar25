using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    [Serializable]
    public class Estudios
    {
        string Nombre, Direccion, FechaA;
        public Estudios(string n, string d, string f)
        {
            Nombre = n;
            Direccion = d;
            FechaA = f;
        }
        public string getName()
        {
            return this.Nombre;
        }
        public string getDireccion()
        {
            return this.Direccion;
        }
        public string getFechaA()
        {
            return this.FechaA;
        }
    }
}
