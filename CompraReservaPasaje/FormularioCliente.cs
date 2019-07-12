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
        int idcli;
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


        private void button2_Click(object sender, EventArgs e)
        {

            SqlCommandBuilder cb = new SqlCommandBuilder(adp);
            adp.Update(dataset);
            confirmarDatos();
            SqlConnection cn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
            cn1.Open();
            SqlCommand sc = new SqlCommand("select LOS_QUE_VAN_A_APROBAR.ClienteNoPuedeComprar(@IdCliente, @FechaSalida, @IdViaje)", cn1);
            sc.Parameters.Add("@IdCliente", SqlDbType.Int).Value = this.idcli;
            sc.Parameters.Add("@FechaSalida", SqlDbType.DateTime2, 3).Value = this.FechaSalida;
            sc.Parameters.Add("@IdViaje", SqlDbType.Int).Value = this.IdViaje;
            sc.CommandType = CommandType.Text;
            int result = Convert.ToInt32(sc.ExecuteScalar());
            cn1.Close();
            cn1.Dispose();
            if (result == 0)
            {
                MessageBox.Show("Usted ya tiene un viaje pendiente en esa fecha");
            }
            else
            {

                Pago f = new Pago(idcli, IdViaje, TipoCabina, FechaSalida, Cantidad);
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
                this.Dispose();
            }
        }



        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
                cn.Open();
                SqlCommand sc = new SqlCommand("select Nombre, Apellido, DNI, Direccion, Telefono, Mail, FechaNacimiento from LOS_QUE_VAN_A_APROBAR.Cliente where DNI = @dni", cn);

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
            catch (FormatException)
            {
                MessageBox.Show("El dni debe ser un numero entero sin puntos ni comas");
            }

           

        }

        private void buttonReservar_Click(object sender, EventArgs e)
        {

            confirmarDatos();

            SqlConnection cn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
            cn1.Open();
            SqlCommand sc = new SqlCommand("select LOS_QUE_VAN_A_APROBAR.ClienteNoPuedeComprar(@IdCliente, @FechaSalida, @IdViaje)", cn1);
            sc.Parameters.Add("@IdCliente", SqlDbType.Int).Value = this.idcli;
            sc.Parameters.Add("@FechaSalida", SqlDbType.DateTime2, 3).Value = this.FechaSalida;
            sc.Parameters.Add("@IdViaje", SqlDbType.Int).Value = this.IdViaje;
            sc.CommandType = CommandType.Text;
            int result = Convert.ToInt32(sc.ExecuteScalar());
            cn1.Close();
            cn1.Dispose();
            if (result == 0)
            {
                MessageBox.Show("Usted ya tiene un viaje pendiente en esa fecha");
            }
            else
            {
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
                this.Dispose();
            }
        }
           
        

        private void confirmarDatos() {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("select LOS_QUE_VAN_A_APROBAR.clienteSeleccionado(@DNI, @Nombre, @Apellido, @Direccion)", cn))
                {
                    cn.Open();
                    cmd.CommandType = CommandType.Text;
                    
                    
                    int fila = dataGridView1.CurrentCell.RowIndex;
                    
                    string nombre = (string) dataGridView1.Rows[fila].Cells[0].Value;
                    string apellido = (string) dataGridView1.Rows[fila].Cells[1].Value;
                    decimal dni = (decimal) dataGridView1.Rows[fila].Cells[2].Value;
                    string direccion = (string) dataGridView1.Rows[fila].Cells[3].Value;
                    

                    cmd.Parameters.AddWithValue("@DNI", dni);
                    
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    
                    cmd.Parameters.AddWithValue("@Apellido", apellido);
                    
                    cmd.Parameters.AddWithValue("@Direccion", direccion);

                    int resultado = Convert.ToInt32(cmd.ExecuteScalar());

                    if (resultado < 0)
                    {
                        MessageBox.Show("Cliente no encontrado");
                    }
                    else
                    {
                        idcli = resultado;                    }

                    cn.Close();
                }


            }
        }
        

        
        
    }
}
