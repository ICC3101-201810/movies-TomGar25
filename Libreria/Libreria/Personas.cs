using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    [Serializable]
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
        public string getName()
        {
            return this.Nombre;
        }
        public string getApellido()
        {
            return this.Apellido;
        }
        public string getFechaN()
        {
            return this.FechaN;
        }
        public string getBiografia()
        {
            return this.Biografia;
        }
        public bool getActor()
        {
            return this.actor;
        }
        public bool getDirector()
        {
            return this.director;
        }
        public bool getProductor()
        {
            return this.productor;
        }

    }

}
