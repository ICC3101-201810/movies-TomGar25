using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Libreria
{
    public partial class Inicio2 : Form
    {
        public Inicio2()
        {
            InitializeComponent();
            this.Show();
            label1.Show();
            Application.DoEvents();
            Thread.Sleep(5000);
            this.Close();

            
        }

        private void Inicio2_Load(object sender, EventArgs e)
        {
          

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

    }
}
