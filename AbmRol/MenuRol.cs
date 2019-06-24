using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmRol
{
    public partial class MenuRol : Form
    {
        public MenuRol()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginYSeguridad.menuAdmin form = new LoginYSeguridad.menuAdmin();
            form.Show();
            this.Dispose();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AltaRol form = new AltaRol();
            form.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BajaRol form = new BajaRol();
            form.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModificarRol form = new ModificarRol();
            form.Show();
            this.Dispose();
        }
    }
}
