using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    [Serializable]
    public class Peliculas
    {
        string Nombre, Fecha_Estreno, Descripcion, Presupuesto;
        Estudios Estudio;
        Personas director;
        public Peliculas(string n, Personas d ,string f, string des, string pre, Estudios es)
        {
            Nombre = n;
            director = d;
            Fecha_Estreno = f;
            Descripcion = des;
            Presupuesto = pre;
            Estudio = es;
        }
        public string getName()
        {
            return this.Nombre;
        }
        public Personas getPersonas()
        {
            return this.director;
        }
        public string getFechaE()
        {
            return this.Fecha_Estreno;
        }
        public string getDescripcion()
        {
            return this.Descripcion;
        }
        public string getPresupuesto()
        {
            return this.Presupuesto;
        }
        public Estudios getEstudio()
        {
            return this.Estudio;
        }
    }
}
