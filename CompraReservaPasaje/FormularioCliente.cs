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
    public partial class FormularioCliente : Form
    {
        int Cantidad;
        int IdViaje;
        DateTime FechaSalida;
        string TipoCabina;
        SqlDataAdapter adp;
        DataTable dataset;

        public FormularioCliente(int viaj, int cant, DateTime fs, string tc)
        {
            FechaSalida = fs;
            TipoCabina = tc;
            IdViaje = viaj;
            Cantidad = cant;
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreCrucero_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlCommandBuilder cb = new SqlCommandBuilder(adp);
            adp.Update(dataset);
            int fila = dataGridView1.CurrentCell.RowIndex;
            int idcli =(int) dataGridView1.Rows[fila].Cells[0].Value;
            Pago f = new Pago(idcli, IdViaje, TipoCabina, FechaSalida, Cantidad);
            f.Show();
        }

        private void FormularioCliente_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
            cn.Open();
            SqlCommand sc = new SqlCommand("select IdCliente, Nombre, Apellido, DNI, Direccion, Telefono, Mail, FechaNacimiento from LOS_QUE_VAN_A_APROBAR.Cliente where DNI = @dni", cn);
            if (string.IsNullOrEmpty(textBoxDni.Text))
            {
                textBoxDni.Text = "0";
            }
            sc.Parameters.Add("@dni", SqlDbType.Decimal).Value = Decimal.Parse(textBoxDni.Text);
            sc.Parameters["@dni"].Precision = 18;
            sc.Parameters["@dni"].Scale = 0;
            adp = new SqlDataAdapter();
            adp.SelectCommand = sc;
            dataset = new DataTable();
            adp.Fill(dataset);
            BindingSource bsource = new BindingSource();


            bsource.DataSource = dataset;
            dataGridView1.DataSource = bsource;
            

        }

        private void buttonReservar_Click(object sender, EventArgs e)
        {
            try
            {
                int f = dataGridView1.CurrentCell.RowIndex;
                int idcli = (int)dataGridView1.Rows[f].Cells[0].Value;

                for (int i = 0; i < Cantidad; i++)
                {
                    using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString))
                    {


                        using (SqlCommand cmd = new SqlCommand("LOS_QUE_VAN_A_APROBAR.GenerarReserva", cn))
                        {
                            cn.Open();
                            cmd.CommandType = CommandType.StoredProcedure;



                            cmd.Parameters.AddWithValue("@IdCliente", idcli);


                            cmd.Parameters.AddWithValue("@IdViaje", IdViaje);


                            cmd.Parameters.AddWithValue("@TipoServicio", TipoCabina);


                            cmd.Parameters.AddWithValue("@Fecha_Salida", FechaSalida);


                            cmd.ExecuteNonQuery();
                            cn.Close();
                            cn.Dispose();
                        }

                    }
                }
                InformacionReserva form = new InformacionReserva(idcli, IdViaje);
                form.Show();
            }
            catch (FormatException)
            {
                MessageBox.Show("El dni debe ser un numero entero sin puntos ni comas");
            }

           
        }
        
    }
}
