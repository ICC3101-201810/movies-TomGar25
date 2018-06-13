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
    public partial class critic : Form
    {
        BaseDatos db = new BaseDatos();
        public critic()
        {
            InitializeComponent();
            db.informacion();
            foreach (Peliculas item in db.pelis)
            {
                BOX.Items.Add(item.getName());
            }
                
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IEnumerable<Peliculas> opciones = db.pelis.Where(pelicul => pelicul.getName().ToLower().Contains(BOX.Text.ToLower()));
            foreach (Peliculas item in opciones)
            {
                db.Criticas.Add(new Critica(TB.Text, CRIT.Text, item));
            }
        }
    }
}
