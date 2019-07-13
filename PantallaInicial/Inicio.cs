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

namespace FrbaCrucero.PantallaInicial
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnClie_Click(object sender, EventArgs e)
        {
            CompraReservaPasaje.CompraReserva Form = new CompraReservaPasaje.CompraReserva();
            Form.StartPosition = FormStartPosition.CenterScreen;
            Form.Show();
            this.Dispose();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            LoginYSeguridad.Login Login = new LoginYSeguridad.Login();
            Login.StartPosition = FormStartPosition.CenterScreen;
            Login.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("LOS_QUE_VAN_A_APROBAR.ChequearReservas", cn))
                {
                    cn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    cn.Dispose();
                }

            } 
            PagoReserva.InfoReserva f = new PagoReserva.InfoReserva();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }
    }
}
