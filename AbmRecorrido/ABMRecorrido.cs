using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmRecorrido
{
    public partial class ABMRecorrido : Form
    {
        public ABMRecorrido()
        {
            InitializeComponent();
        }

        private void ABMRecorrido_Load(object sender, EventArgs e)
        {

        }

        private void btnAltaRecorrido_Click(object sender, EventArgs e)
        {
            AltaRecorrido form = new AltaRecorrido();
            form.Show();
            //this.Dispose();
        }

        private void btnBajaRecorrido_Click(object sender, EventArgs e)
        {
            BajaRecorrido form = new BajaRecorrido();
            form.Show();
            //this.Dispose();
        }

        private void btnModificarRecorrido_Click(object sender, EventArgs e)
        {
            ModificarRecorrido form = new ModificarRecorrido();
            form.Show();
            //this.Dispose();
        }


    }
}
