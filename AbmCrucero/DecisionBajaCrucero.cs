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
    public partial class DecisionBajaCrucero : Form
    {
        public DecisionBajaCrucero()
        {
            InitializeComponent();
            txtDisponibilidad.Hide();
            cargarTxtDisponibilidad();
        }

        private void cargarTxtDisponibilidad()
        {
        }
    }
}
