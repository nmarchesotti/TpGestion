using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmPuerto
{
    public partial class ABMPuerto : Form
    {
        public ABMPuerto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BajaPuerto form = new BajaPuerto();
            form.Show();
            this.Dispose();
        }

        private void btnABMAltaPuerto_Click(object sender, EventArgs e)
        {
            AltaPuerto form = new AltaPuerto();
            form.Show();
            this.Dispose();
        }

        private void btnABMModificarPuerto_Click(object sender, EventArgs e)
        {
            ModificarPuerto form = new ModificarPuerto();
            form.Show();
            this.Dispose();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            ListadoPuertos form = new ListadoPuertos();
            form.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
