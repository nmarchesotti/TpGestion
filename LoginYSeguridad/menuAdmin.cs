using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.LoginYSeguridad
{
    public partial class menuAdmin : Form
    {
        public menuAdmin()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CompraReservaPasaje.CompraReserva Form = new CompraReservaPasaje.CompraReserva();
            Form.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbmCrucero.ABMCrucero Form = new AbmCrucero.ABMCrucero();
            Form.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbmPuerto.ABMPuerto Form = new AbmPuerto.ABMPuerto();
            Form.Show();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbmRecorrido.ABMRecorrido Form = new AbmRecorrido.ABMRecorrido();
            Form.Show();
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbmRol.MenuRol Form = new AbmRol.MenuRol();
            Form.Show();
            this.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GeneracionViaje.Form1 Form = new GeneracionViaje.Form1();
            Form.Show();
            this.Dispose();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ListadoEstadistico.Form1 Form = new ListadoEstadistico.Form1();
            Form.Show();
            this.Dispose();
        }
    }
}
