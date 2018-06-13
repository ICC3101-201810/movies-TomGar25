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
        BaseDatos bs = new BaseDatos();
        
        public Main()
        {
            InitializeComponent();
            
 
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string barra = Searching.Text;
            bool a = Metodos.caracter(barra);
            if (a)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string barra = Searching.Text;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string barra = Searching.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string barra = Searching.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string barra = Searching.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
