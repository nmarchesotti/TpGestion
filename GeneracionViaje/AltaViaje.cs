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

namespace FrbaCrucero.GeneracionViaje
{
    public partial class AltaViaje : Form
    {
        public AltaViaje()
        {
            InitializeComponent();
            cargarComboBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuViaje form = new MenuViaje();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Dispose();
        }

        private void fechaLlegada_ValueChanged(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString))
            {
                cn.Open();
                SqlCommand sc = new SqlCommand("select * from LOS_QUE_VAN_A_APROBAR.crucerosParaViaje(@Fecha_SalidaNueva, @Fecha_LlegadaNueva)", cn);

                sc.Parameters.AddWithValue("@Fecha_SalidaNueva", Convert.ToDateTime(fechaSalida.Text));

                sc.Parameters.AddWithValue("@Fecha_LlegadaNueva", Convert.ToDateTime(fechaLlegada.Text));
                
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("IdCrucero", typeof(string));
                dt.Load(reader);

                comboBoxCruceros.ValueMember = "IdCrucero";
                comboBoxCruceros.DisplayMember = "IdCrucero";
                comboBoxCruceros.DataSource = dt;
                cn.Close();
                cn.Dispose();
            }
        }

        private void cargarComboBox()
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString))
            {
                cn.Open();
                SqlCommand sc = new SqlCommand("select CodigoRecorrido, (PuertoSalida + ' - ' + PuertoLlegada + ' -- Cantidad de tramos: ' + CAST (CantidadDeTramos as nvarchar)) as Informacion from LOS_QUE_VAN_A_APROBAR.ListarRecorridos", cn);
                SqlDataReader reader;
                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("CodigoRecorrido", typeof(string));
                dt.Columns.Add("Informacion", typeof(string));
                dt.Load(reader);

                comboBoxRecorrido.ValueMember = "CodigoRecorrido";
                comboBoxRecorrido.DisplayMember = "Informacion";
                comboBoxRecorrido.DataSource = dt;
                cn.Close();
                cn.Dispose();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString))
                {
                    cn.Open();


                    using (SqlCommand cmd = new SqlCommand("LOS_QUE_VAN_A_APROBAR.GenerarViaje", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        DataRowView drv = (DataRowView)comboBoxCruceros.SelectedItem;
                        string IdCrucero = Convert.ToString(drv["IdCrucero"]);
                        cmd.Parameters.Add("@IdCrucero", SqlDbType.NVarChar, 50).Value = IdCrucero;

                        DataRowView drv2 = (DataRowView)comboBoxRecorrido.SelectedItem;
                        int IdRecorrido = Convert.ToInt32(drv2["CodigoRecorrido"]);
                        cmd.Parameters.Add("@IdRecorrido", SqlDbType.Int).Value = IdRecorrido;

                        DateTime fechaS = Convert.ToDateTime(fechaSalida.Text);
                        cmd.Parameters.Add("@Fecha_Salida", SqlDbType.DateTime2, 3).Value = fechaS;

                        DateTime fechaL = Convert.ToDateTime(fechaLlegada.Text);
                        cmd.Parameters.Add("@Fecha_Llegada", SqlDbType.DateTime2, 3).Value = fechaL;

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Viaje creado satisfactoriamente");
                        cn.Close();
                        cn.Dispose();
                        MenuViaje form = new MenuViaje();
                        form.StartPosition = FormStartPosition.CenterScreen;
                        form.Show();
                        this.Dispose();


                    }
                }
            }
            catch
            {
                MessageBox.Show("La fecha de salida debe ser mayor a la actual");
            }
        }

        private void comboBoxCruceros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
