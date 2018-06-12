using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.IO;

namespace Libreria
{
    public class BaseDatos
    {
        List<Peliculas> pelis;
        List<Estudios> estudio;
        List<PeliculaProductor> pelisProductor;
        List<PeliculaActor> pelisActor;
        List<Personas> people;


        public static void Serializar(List<Peliculas> pelis)
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Depeliculas");
                using (Stream stream = File.Open(path, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, pelis);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public static List<Peliculas> deserializar()
        {
            List<Peliculas> peliculasD;
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Depeliculas");
                using (Stream stream = File.Open(path, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    peliculasD = (List<Peliculas>)bin.Deserialize(stream);
                }
                return peliculasD;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
    }
}
