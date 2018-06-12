using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Libreria
{
    public class Metodos
    {
        public static void SerializarPeliculas(List<Peliculas> pelis)
        {
            try
            {
                
            }
            catch (Exception e)
            {
                
            }
        }
        public static bool caracter(string palabra)
        {
            int a = palabra.Length;
            if (a>= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
            


        
    }
}
