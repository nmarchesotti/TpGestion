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

namespace FrbaCrucero.AbmCrucero
{
    public partial class EleccionBaja : Form
    {
        string IdCrucero;
        public EleccionBaja(string IdCrucero)
        {
            InitializeComponent();
            this.IdCrucero = IdCrucero;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString))
            {
                if (checkBox1.Checked)
                {
                    DateTime fechaAReprogramar = Convert.ToDateTime(dateTimePicker1.Text);

                    using (SqlCommand cmd = new SqlCommand("LOS_QUE_VAN_A_APROBAR.reprogramarViajes", cn))
                    {

                    }
                }
            }
        }
    }
}
