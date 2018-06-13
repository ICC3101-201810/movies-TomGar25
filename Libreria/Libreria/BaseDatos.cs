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
    [Serializable]
    public class BaseDatos
    {
        public List<Peliculas> pelis = new List<Peliculas>();
        public List<Estudios> estudio = new List<Estudios>();
        public List<PeliculaProductor> pelisProductor = new List<PeliculaProductor>();
        public List<PeliculaActor> pelisActor= new List<PeliculaActor>();
        public List<Personas> people1= new List<Personas>();
        public List<Personas> people2 = new List<Personas>();
        public List<Personas> people3 = new List<Personas>();
        public List<Critica> Criticas = new List<Critica>();


        public BaseDatos()
        {
           
        }
        public void informacion()
        {
            //Estudios
            estudio.Add(new Estudios("Paramount Studios","5555 Melros, LA","8/05/1912"));
            estudio.Add(new Estudios("Marvel Studios", "500 S Buena Vista, Burbank ", "16/10/1993"));
            estudio.Add(new Estudios("Warner Bros Studios", "3400 W Riverside DR ", "04/04/1923"));
            //actores
            people1.Add(new Personas("Margot", "Robbie", "02/07/1990","Sin comentarios", true, false, false)); //0
            people1.Add(new Personas("Morena", "Baccarin", "02/06/1979", "Actua bien", true, false, false));
            people1.Add(new Personas("Gabrielle", "Union", "29/10/1972", "Una crack", true, false, false));
            people1.Add(new Personas("Amy", "Adams", "20/08/1985", "Una crack tb", true, false, false)); //3
            people1.Add(new Personas("Will", "Smith", "25/09/1968", "Crack", true, false, false)); //4
            people1.Add(new Personas("Mark", "Wahlberg", "05/06/1971", "Crack to", true, false, false)); //5
            people1.Add(new Personas("Dwayne", "Johnson", "02/05/1972", "El mas crack", true, false, false)); //6
            people1.Add(new Personas("Ryan", "Reynolds", "23/10/1976", "Crack tb", true, false, false));
            //directores
            people2.Add(new Personas("Michael", "Bay", "17/02/1965", "Master", false, true,false));
            people2.Add(new Personas("David", "Leitch", "06/07/1969", "Maquinon", false, true, false));
            people2.Add(new Personas("David", "Russell", "20/08/1958", "Maquinon", false, true, false));
            people2.Add(new Personas("Martin", "Scorsese", "17/11/1942", "", false, true, false));
            //productores
            people3.Add(new Personas("Jake", "Paul", "06/07/1966", "Fitness", false, false, true));
            people3.Add(new Personas("Chris", "Smith", "17/03/1991", "Fitness", false, false, true));
            people3.Add(new Personas("Will", "Stallone", "06/07/1982", "Fitness", false, false, true));
            //Peliculas
            pelis.Add(new Peliculas("Pain & Gain", people2[0],"12/09/2013","Comedia, drama","35,000,000 dolares", estudio[0]));
            pelis.Add(new Peliculas("Deadpool 2",people2[1], "15/05/2018", "Comedia, accion", "110,000,000 dolares", estudio[1]));
            pelis.Add(new Peliculas("Bad Boys 2", people2[0], "09/07/2003", "Accion, policial", "130,000,000 dolares", estudio[0]));
            pelis.Add(new Peliculas("The fighter", people2[2], "06/12/2010", "Box", "25,000,000 dolares", estudio[2]));
            pelis.Add(new Peliculas("The Wolf of Wall Street", people2[3], "02/01/2014", "Drama", "100,000,000 dolares", estudio[0]));

            pelisActor.Add(new PeliculaActor(pelis[4],people1[0]));
            pelisActor.Add(new PeliculaActor(pelis[0], people1[5]));
            pelisActor.Add(new PeliculaActor(pelis[0], people1[6]));
            pelisActor.Add(new PeliculaActor(pelis[1], people1[7]));
            pelisActor.Add(new PeliculaActor(pelis[1], people1[1]));
            pelisActor.Add(new PeliculaActor(pelis[2], people1[4]));
            pelisActor.Add(new PeliculaActor(pelis[2], people1[2]));
            pelisActor.Add(new PeliculaActor(pelis[3], people1[5]));
            pelisActor.Add(new PeliculaActor(pelis[3], people1[3]));

            pelisProductor.Add(new PeliculaProductor(pelis[0], people3[0]));
            pelisProductor.Add(new PeliculaProductor(pelis[1], people3[0]));
            pelisProductor.Add(new PeliculaProductor(pelis[2], people3[1]));
            pelisProductor.Add(new PeliculaProductor(pelis[3], people3[1]));
            pelisProductor.Add(new PeliculaProductor(pelis[4], people3[2]));
        }

        
    }
}
