using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmCrucero
{
    public partial class ABMCrucero : Form
    {
        public ABMCrucero()
        {
            InitializeComponent();
        }


        private void btnABMAltaCrucero_Click(object sender, EventArgs e)
        {
            AbmCrucero.AltaCrucero form = new AltaCrucero();
            form.Show();
            this.Dispose();
        }

        private void btnABMBajaCrucero_Click(object sender, EventArgs e)
        {
            AbmCrucero.BajaCrucero form = new BajaCrucero();
            form.Show();
            this.Dispose();
        }

        private void btnABMModificarCrucero_Click(object sender, EventArgs e)
        {
            AbmCrucero.modificarCrucero form = new modificarCrucero();
            form.Show();
            this.Dispose();
        }

        private void btnListaCruceros_Click(object sender, EventArgs e)
        {
            ListaCruceros form = new ListaCruceros();
            form.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
