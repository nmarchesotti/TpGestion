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
        public List<String> funcionalidades;

        public menuAdmin(List<String> list)
        {
            this.funcionalidades = list;
            InitializeComponent();
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            if (funcionalidades.Contains("Menu CyR"))
            {
                // Falta menu de compra
            }
            else
            {
                MessageBox.Show("No tenes los permisos correspondientes");
            }
        }

        private void btnPuerto_Click(object sender, EventArgs e)
        {
            if (funcionalidades.Contains("Menu puerto"))
            {
                AbmPuerto.ABMPuerto form = new AbmPuerto.ABMPuerto();
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Show();
            }
            else
            {
                MessageBox.Show("No tenes los permisos correspondientes");
            }
        }

        private void btnViaje_Click(object sender, EventArgs e)
        {
            if (funcionalidades.Contains("Menu viajes"))
            {
                GeneracionViaje.MenuViaje form = new GeneracionViaje.MenuViaje();
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Show();
            }
            else
            {
                MessageBox.Show("No tenes los permisos correspondientes");
            }
        }

        private void btnRol_Click(object sender, EventArgs e)
        {
            if (funcionalidades.Contains("Menu rol"))
            {
                AbmRol.MenuRol form = new AbmRol.MenuRol();
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Show();
            }
            else
            {
                MessageBox.Show("No tenes los permisos correspondientes");
            }
        }

        private void btnCrucero_Click(object sender, EventArgs e)
        {
            if (funcionalidades.Contains("Menu crucero"))
            {
                AbmCrucero.ABMCrucero form = new AbmCrucero.ABMCrucero();
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Show();
            }
            else
            {
                MessageBox.Show("No tenes los permisos correspondientes");
            }
        }

        private void btnRecorrido_Click(object sender, EventArgs e)
        {
            if (funcionalidades.Contains("Menu recorrido"))
            {
                AbmRecorrido.ABMRecorrido form = new AbmRecorrido.ABMRecorrido();
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Show();
            }
            else
            {
                MessageBox.Show("No tenes los permisos correspondientes");
            }
        }

        private void btnEstadistica_Click(object sender, EventArgs e)
        {
            if (funcionalidades.Contains("Menu estadistico"))
            {
                ListadoEstadistico.MenuListadoEstadistico form = new ListadoEstadistico.MenuListadoEstadistico();
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Show();
            }
             else
            {
                MessageBox.Show("No tenes los permisos correspondientes");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PantallaInicial.Inicio form = new PantallaInicial.Inicio();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Dispose();
        }






    }
}
