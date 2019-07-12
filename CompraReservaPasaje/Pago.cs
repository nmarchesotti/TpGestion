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

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class Pago : Form
    {
        int idcliente;
        int idviaje;
        DateTime fecha_salida;
        string tipocabina;
        int cantidad;
        decimal precio;
        
        public Pago(int c, int v, string tc, DateTime fs, int cant, decimal prec)
        {
            InitializeComponent();
            idcliente = c;
            idviaje = v;
            fecha_salida = fs;
            tipocabina = tc;
            cantidad = cant;
            precio = prec;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cantidad; i++)
            {
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString))
                {


                    using (SqlCommand cmd = new SqlCommand("LOS_QUE_VAN_A_APROBAR.GenerarPasaje", cn))
                    {
                        cn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        

                        cmd.Parameters.AddWithValue("@IdCliente", idcliente);


                        cmd.Parameters.AddWithValue("@IdViaje", idviaje);


                        cmd.Parameters.AddWithValue("@TipoServicio", tipocabina);


                        cmd.Parameters.AddWithValue("@Fecha_Salida", fecha_salida);


                        cmd.ExecuteNonQuery();

                        
                        cn.Close();
                        cn.Dispose();
                    }

                }

            }

            MessageBox.Show("Pago realizado con éxito, se han comprado " + cantidad + " pasajes");

            InformacionPago form = new InformacionPago(idcliente, idviaje);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Dispose();
        }

        private void Pago_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedIndex.ToString());
            if (Convert.ToInt32(comboBox1.SelectedIndex) == 0) { 
                Mercadopago fo = new Mercadopago();
                fo.Show();
            }
            if (Convert.ToInt32(comboBox1.SelectedIndex) == 1)
            {
                TarjetaDeCredito f = new TarjetaDeCredito();
                f.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
