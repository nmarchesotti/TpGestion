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

namespace FrbaCrucero.PagoReserva
{
    public partial class PagoReserva : Form
    {
        int IdReserva;


        public PagoReserva(int id)
        {
            IdReserva = id;
            InitializeComponent();
        }

        private void PagoReserva_Load(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("select LOS_QUE_VAN_A_APROBAR.precioReserva(@IdReserva)", cn))
                {
                    cn.Open();
                    cmd.CommandType = CommandType.Text;
                    
                    cmd.Parameters.AddWithValue("@IdReserva", IdReserva);

                    decimal resultado = Convert.ToDecimal(cmd.ExecuteScalar());

                    textBox1.Text = Convert.ToString(resultado);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("LOS_QUE_VAN_A_APROBAR.PagarReserva", cn))
                {
                    cn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdReserva", IdReserva);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Reserva pagada exitosamente");

                    cn.Close();
                    cn.Dispose();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedIndex.ToString());
            if (Convert.ToInt32(comboBox1.SelectedIndex) == 0)
            {
                CompraReservaPasaje.Mercadopago fo = new CompraReservaPasaje.Mercadopago();
                fo.Show();
            }
            if (Convert.ToInt32(comboBox1.SelectedIndex) == 1)
            {
                CompraReservaPasaje.TarjetaDeCredito f = new CompraReservaPasaje.TarjetaDeCredito();
                f.Show();
            }
        }



    }
}
