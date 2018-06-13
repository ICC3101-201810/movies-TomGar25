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
    public class Metodos
    {
        public static void SerializarPelis(List<Peliculas> pelis)
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\DATAPELIS");
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
        public static List<Peliculas> deserializarPelis()
        {
            List<Peliculas> peliculasD;
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\DATAPELIS");
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


        //public List<Peliculas> pelis = new List<Peliculas>();
        //public List<Estudios> estudio = new List<Estudios>();
        //public List<PeliculaProductor> pelisProductor = new List<PeliculaProductor>();
        //public List<PeliculaActor> pelisActor = new List<PeliculaActor>();
        //public List<Personas> people = new List<Personas>();

        public static List<string> BuscarPersona(List<Personas> persona1, string barrita)
        {
            List<string> Ls = new List<string>();
            
            IEnumerable<Personas> opciones = persona1.Where(persona => persona.getName().ToLower().Contains(barrita.ToLower()) );         
            foreach (Personas item in opciones)
            {
                if (item.getActor())
                {
                    Ls.Add(item.getName() +" "+ item.getApellido()+"..."+"Actor"+"\n" );
                }
                else if (item.getDirector())
                {
                    Ls.Add(item.getName() + " " + item.getApellido() + "..." + "Director" + "\n");
                }
                else if (item.getProductor())
                {
                    Ls.Add(item.getName() + " " + item.getApellido() + "..." + "Productor" + "\n");
                }
             
            }
            IEnumerable<Personas> opciones1 = persona1.Where(persona => persona.getApellido().ToLower().Contains(barrita.ToLower()));
            foreach (Personas item in opciones1)
            {
                if (item.getActor())
                {
                    Ls.Add(item.getName() + " " + item.getApellido() + "... " + "Actor" + "\n");
                }
                else if (item.getDirector())
                {
                    Ls.Add(item.getName() + " " + item.getApellido() + "... " + "Director" + "\n");
                }
                else if (item.getProductor())
                {
                    Ls.Add(item.getName() + " " + item.getApellido() + "... " + "Productor" + "\n");
                }
            }
            return Ls;
        }


        public static List<string> BuscarPelicula(List<Peliculas> pelicula1, string barrita)
        {
            List<string> Ls = new List<string>();

            IEnumerable<Peliculas> opciones = pelicula1.Where(pelicul => pelicul.getName().ToLower().Contains(barrita.ToLower()));
            foreach (Peliculas item in opciones)
            {
               
                Ls.Add(item.getName() + "... " + "Pelicula" + "\n");
                
            }
            IEnumerable<Peliculas> opciones1 = pelicula1.Where(pelucul => pelucul.getDescripcion().ToLower().Contains(barrita.ToLower()));
            foreach (Peliculas item in opciones1)
            {

                Ls.Add(item.getName() + "... " + "Pelicula" + "\n");

            }
            return Ls;
        }

        public static List<string> BuscarEstudio(List<Estudios> es1, string barrita)
        {
            List<string> Ls = new List<string>();

            IEnumerable<Estudios> opciones = es1.Where(pes => pes.getName().ToLower().Contains(barrita.ToLower()));
            foreach (Estudios item in opciones)
            {

                Ls.Add(item.getName() + "... " + "Estudio" + "\n");

            }
            IEnumerable<Estudios> opciones1 = es1.Where(pel=> pel.getDireccion().ToLower().Contains(barrita.ToLower()));
            foreach (Estudios item in opciones1)
            {

                Ls.Add(item.getName() + "... " + "Estudio" + "\n");

            }
            return Ls;
        }


        public static List<string> PelisvsProductor(List<PeliculaProductor> pelis1, string nombrecompleto)
        {
            List<string> Ld = new List<string>();
            IEnumerable<PeliculaProductor> pelicula = pelis1.Where(peli => peli.getPelicula().getName() == nombrecompleto);
            foreach (PeliculaProductor item in pelicula)
            {
                Ld.Add(item.getProductor().getName() + " " + item.getProductor().getApellido());
            }
            return Ld;
        }
        public static List<string> PelisvsActor(List<PeliculaActor> pelis1, string nombrecompleto)
        {
            List<string> Ld = new List<string>();
            IEnumerable<PeliculaActor> pelicula = pelis1.Where(peli => peli.getPelicula().getName() == nombrecompleto);
            foreach (PeliculaActor item in pelicula)
            {
                Ld.Add(item.getActorr().getName()+" "+item.getActorr().getApellido());
            }
            return Ld;
        }

        public static List<string> BActorenPeliculas(List<PeliculaActor> pelis1, string nombrecompleto)
        {
            List<string> Ld = new List<string>();
            IEnumerable<PeliculaActor> pelicula = pelis1.Where(peli => (peli.getActorr().getName()+" "+peli.getActorr().getApellido())==nombrecompleto);
            foreach (PeliculaActor item in pelicula)
            {
                Ld.Add(item.getPelicula().getName());
            }
            return Ld;
        }
        public static List<string> productorvsPeliculas(List<PeliculaProductor> pelis1, string nombrecompleto)
        {
            List<string> Ld = new List<string>();
            IEnumerable<PeliculaProductor> pelicula = pelis1.Where(peli => (peli.getProductor().getName() + " " + peli.getProductor().getApellido()) == nombrecompleto);
            foreach (PeliculaProductor item in pelicula)
            {
                Ld.Add(item.getPelicula().getName());
            }
            return Ld;
        }
        public static List<string> directorvsPeliculas(List<Peliculas> pelis1, string nombrecompleto)
        {
            List<string> Ld = new List<string>();
            IEnumerable<Peliculas> pelicula = pelis1.Where(peli => (peli.getPersonas().getName() + " " + peli.getPersonas().getApellido()) == nombrecompleto);
            foreach (Peliculas item in pelicula)
            {
                Ld.Add(item.getName());
            }
            return Ld;
        }
        public static List<string> PelisvsEstudios(List<Peliculas> pelis1, string nombrecompleto)
        {
            List<string> Ld = new List<string>();
            IEnumerable<Peliculas> pelicula = pelis1.Where(peli => peli.getEstudio().getName().Contains(nombrecompleto) );
            foreach (Peliculas item in pelicula)
            {
                Ld.Add(item.getName());
            }
            return Ld;
        }




    }
}
