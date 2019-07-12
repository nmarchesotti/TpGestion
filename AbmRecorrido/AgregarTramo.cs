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

namespace FrbaCrucero.AbmRecorrido
{
    public partial class AgregarTramo : Form
    {
        string puerto_llegada;
        public Decimal Precio;
        public AgregarTramo()
        {
            InitializeComponent();
            comboBoxPuertoS_Load();
            comboBoxPuertoL_Load();
            
        }

        private void AgregarTramo_Load(object sender, EventArgs e)
        {
        }
            private void comboBoxPuertoS_Load()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
            cn.Open();
            SqlCommand sc = new SqlCommand("select Nombre from LOS_QUE_VAN_A_APROBAR.Puerto", cn);
            SqlDataReader reader;
            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Nombre", typeof(String));
            dt.Load(reader);

            comboBoxPuertoS.ValueMember = "Nombre";
            comboBoxPuertoS.DisplayMember = "Nombre";
            comboBoxPuertoS.DataSource = dt;

            cn.Close();
        }

        private void comboBoxPuertoL_Load()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
            cn.Open();
            SqlCommand sc = new SqlCommand("select Nombre from LOS_QUE_VAN_A_APROBAR.Puerto", cn);
            SqlDataReader reader;
            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Nombre", typeof(String));
            dt.Load(reader);

            comboBoxPuertoL.ValueMember = "Nombre";
            comboBoxPuertoL.DisplayMember = "Nombre";
            comboBoxPuertoL.DataSource = dt;

            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            DataRowView drv2 = (DataRowView)comboBoxPuertoS.SelectedItem;
            string PuertoSalida = Convert.ToString(drv2["Nombre"]);
                    
            DataRowView drv3 = (DataRowView)comboBoxPuertoL.SelectedItem;
            string PuertoLlegada = Convert.ToString(drv3["Nombre"]);

            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString))
            {
                cn.Open();

                SqlCommand com = new SqlCommand("select LOS_QUE_VAN_A_APROBAR.ExisteTramo(@PuertoSalida, @PuertoLlegada)", cn);
                com.CommandType = CommandType.Text;

                com.Parameters.AddWithValue("@PuertoSalida", PuertoSalida);

                com.Parameters.AddWithValue("@PuertoLlegada", PuertoLlegada);

                int res = Convert.ToInt32(com.ExecuteScalar());

                if (res == 1)
                {

                    MessageBox.Show("El tramo no existe, por favor ingrese un precio e intente nuevamente");
                    NuevoTramo n = new NuevoTramo(PuertoSalida, PuertoLlegada);
                    n.Show();
                }

                else { 
                
                using (SqlCommand cmd = new SqlCommand("LOS_QUE_VAN_A_APROBAR.InsertarTramoDeRecorrido", cn))
                {
                    SqlCommand cmd2 = new SqlCommand("select top 1 IdRecorrido from LOS_QUE_VAN_A_APROBAR.Recorrido ORDER BY IdRecorrido Desc", cn);
                    cmd2.CommandType = CommandType.Text;
                    int IdRecorrido = Convert.ToInt32(cmd2.ExecuteScalar());
      
                
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@CodigoRecorrido", SqlDbType.Int).Value = IdRecorrido;
                    cmd.Parameters.Add("@PuertoSalida", SqlDbType.NVarChar,255).Value = PuertoSalida;
                    
                    cmd.Parameters.Add("@PuertoLlegada", SqlDbType.NVarChar,255).Value = PuertoLlegada;
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tramo agregado al recorrido");
                    puerto_llegada = PuertoLlegada;

                    cn.Close();
                    cn.Dispose();
                }

                comboBoxPuertoS.SelectedValue = puerto_llegada;
                comboBoxPuertoS.Enabled = false;
            }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ABMRecorrido form = new ABMRecorrido();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Dispose();
        }
        }

        
    }

