using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.PagoReserva
{
    public partial class InfoReserva : Form
    {
        public InfoReserva()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grid_load()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
            cn.Open();
            SqlCommand sc = new SqlCommand("select IdReserva, IdViaje, NroPiso, NroCabina, Fecha_Salida from LOS_QUE_VAN_A_APROBAR.Reserva where IdReserva = @IdReserva", cn);
            sc.Parameters.Add("@IdReserva", SqlDbType.Int, 100).Value = Convert.ToInt32(textBoxRes.Text);


            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = sc;
            DataTable dataset = new DataTable();
            adp.Fill(dataset);
            BindingSource bsource = new BindingSource();


            bsource.DataSource = dataset;
            dataGridView1.DataSource = bsource;
            adp.Update(dataset);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("select LOS_QUE_VAN_A_APROBAR.ValidarReserva(@IdReserva)", cn))
                    {
                        cn.Open();
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@IdReserva", SqlDbType.Int, 100).Value = Convert.ToInt32(textBoxRes.Text);
                        int resultado = Convert.ToInt32(cmd.ExecuteScalar());

                        if (resultado == 1)
                        {
                            grid_load();
                        }
                        else
                        {
                            MessageBox.Show("Reserva expirada o número invalido");
                        }

                        cn.Close();
                    }


                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El codigo de reserva es un numero entero y positivo");
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("select LOS_QUE_VAN_A_APROBAR.ValidarReserva(@IdReserva)", cn))
                    {
                        cn.Open();
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@IdReserva", SqlDbType.Int, 100).Value = Convert.ToInt32(textBoxRes.Text);
                        int resultado = Convert.ToInt32(cmd.ExecuteScalar());



                        cn.Close();
                    }


                    int res = (int)dataGridView1.Rows[0].Cells[0].Value;
                    PagoReserva f = new PagoReserva(res);
                    f.Show();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El código de reserva es un número entero y positivo");
            }
            catch {
                MessageBox.Show("Primero debe buscar la reserva");
            }

        }

        


    }

}
