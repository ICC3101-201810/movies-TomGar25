using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreria
{
    public partial class Main : Form
    {
        BaseDatos db = new BaseDatos();
        
        public Main()
        {
            //Metodos.deserializarPelis();
            InitializeComponent();
            db.informacion();
            

        }

        private void button2_Click(object sender, EventArgs e) //Actores
        {
            ComboBox.Items.Clear();
            foreach (Personas item in db.people1)
            {
                ComboBox.Items.Add(item.getName() + " " + item.getApellido());
            }
        }

        private void button1_Click(object sender, EventArgs e) //peliculas
        {
            ComboBox.Items.Clear();
            foreach (Peliculas item in db.pelis)
            {
                ComboBox.Items.Add(item.getName());
            }            
        }

        private void button3_Click(object sender, EventArgs e) //directores
        {
            ComboBox.Items.Clear();
            foreach (Personas item in db.people2)
            {
                ComboBox.Items.Add(item.getName()+" "+ item.getApellido());
            }
        }

        private void button4_Click(object sender, EventArgs e) //prodctores
        {
            ComboBox.Items.Clear();
            foreach (Personas item in db.people3)
            {
                ComboBox.Items.Add(item.getName() + " " + item.getApellido());
            }

        }

        private void button5_Click(object sender, EventArgs e) // estudios
        {
            ComboBox.Items.Clear();
            foreach (Estudios item in db.estudio)
            {
                ComboBox.Items.Add(item.getName());
            }
        }

        private void button6_Click(object sender, EventArgs e) //todo
        {
            Metodos.SerializarPelis(db.pelis);
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string barra = Searching.Text;
            if (barra.Length < 3)
            {
                MessageBox.Show("ingrese 3 caracteres");
            }
            else
            {
                string mensaje = "";
                List<string> mach = Metodos.BuscarPersona(db.people1, barra);
                List<string> p1 = Metodos.BuscarPersona(db.people2, barra);
                List<string> p2 = Metodos.BuscarPersona(db.people3, barra);
                List<string> p3 = Metodos.BuscarPelicula(db.pelis, barra);
                List<string> p4 = Metodos.BuscarEstudio(db.estudio, barra);

                foreach (string item in mach)
                {
                    mensaje += item;
                }
                foreach (string item in p1)
                {
                    mensaje += item;
                }
                foreach (string item in p2)
                {
                    mensaje += item;
                }
                foreach (string item in p3)
                {
                    mensaje += item;
                }
                foreach (string item in p4)
                {
                    mensaje += item;

                }
                MessageBox.Show(mensaje);
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string cb = ComboBox.Text;
            if (cb != "")
            {
                string men = "Informacion: \n";
                string men1 = "Informacion: \n";
                string men2 = "Informacion: \n";
                string men3 = "Informacion: \n";
                string men4 = "Informacion: \n";


                IEnumerable<Peliculas> seleccionada = db.pelis.Where(pelis => pelis.getName().Contains(cb)); //Peliculas
                List<string> anexo1 = Metodos.PelisvsActor(db.pelisActor, cb);
                List<string> anexo11 = Metodos.PelisvsProductor(db.pelisProductor, cb);

                foreach (Peliculas item in seleccionada)
                {
                    men += "Nombre: " + item.getName() + "\n" + "Director: " + item.getPersonas().getName()+ " "+ item.getPersonas().getApellido()+ "\n" + "Fecha Estreno: " + item.getFechaE() + "\n" + "Desc: " + item.getDescripcion() + "\n" + "Presupuesto: " + item.getPresupuesto() + "\n" + "Estudio: " + item.getEstudio().getName()+"\n";
                }
                foreach (string i in anexo1)
                {
                    men += "Actor/Actriz: "+i +"\n";
                }
                foreach (string i in anexo11)
                {
                    men +=  "Productor: " +i  + "\n";
                }
                IEnumerable<Estudios> seleccionada1 = db.estudio.Where(es => es.getName().Contains(cb)); //Estudios
                List<string> esee = Metodos.PelisvsEstudios(db.pelis,cb);
                foreach (Estudios item in seleccionada1)
                {
                    men1 += "Nombre: " + item.getName() + "\n" + "Direccion: " + item.getDireccion() + "\n" + "Fecha Apertura: " + item.getFechaA()+"\n";
                }
                foreach (string i in esee)
                {
                    men1 += "Peliculas Producidas: " + i + "\n";
                }

                IEnumerable<Personas> seleccionada2 = db.people1.Where(person => (person.getName()+" "+ person.getApellido()) == cb ); //actores
                List<string> anexopelis = Metodos.BActorenPeliculas(db.pelisActor, cb);
                foreach (Personas item in seleccionada2)
                {
                    men2 += "Nombre: " + item.getName() +" "+ item.getApellido() + "\n" + "Fecha Nacimiento: " + item.getFechaN() + "\n" + "Biografia: " + item.getBiografia()+"\n"+ "Actor/Actriz\n";
                }
                foreach(string i in anexopelis)
                {
                    men2 += i + "\n";
                }
                IEnumerable<Personas> seleccionada3 = db.people2.Where(person1 => (person1.getName() + " " + person1.getApellido()) == cb); //Directores
                List<string> anexo3 = Metodos.directorvsPeliculas(db.pelis,cb);
                foreach (Personas item in seleccionada3)
                {
                    men3 += "Nombre: " + item.getName() + " " + item.getApellido() + "\n" + "Fecha Nacimiento: " + item.getFechaN() + "\n" + "Biografia: " + item.getBiografia() + "\n" + "Director\n";
                }
                foreach (string i in anexo3)
                {
                    men3 += i + "\n";
                }
                IEnumerable<Personas> seleccionada4 = db.people3.Where(person2 => (person2.getName() + " " + person2.getApellido()) == cb); //Productores
                List<string> anexo2 = Metodos.productorvsPeliculas(db.pelisProductor, cb);
                foreach (Personas item in seleccionada4)
                {
                    men4 += "Nombre: " + item.getName() + " " + item.getApellido() + "\n" + "Fecha Nacimiento: " + item.getFechaN() + "\n" + "Biografia: " + item.getBiografia() + "\n" + "Productor\n";
                }
                foreach (string i in anexo2)
                {
                    men4 += i + "\n";
                }

                if (men.Length > 20)
                {
                    MessageBox.Show(men);
                    men = "";
                }
                else if (men1.Length > 20)
                {
                    MessageBox.Show(men1);
                    men1 = "";
                }
                else if (men2.Length > 20)
                {
                    MessageBox.Show(men2);
                    men2 = "";
                }
                else if (men3.Length > 20)
                {
                    MessageBox.Show(men3);
                    men3 = "";
                }
                else if (men4.Length > 20)
                {
                    MessageBox.Show(men4);
                    men4 = "";
                }




            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            critic nn = new critic();
            nn.Show();
        }
    }
}
