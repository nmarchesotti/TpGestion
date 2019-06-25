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

            comboBoxPuertoS.ValueMember = "NombreSalida";
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

            comboBoxPuertoL.ValueMember = "NombreLlegada";
            comboBoxPuertoL.DisplayMember = "Nombre";
            comboBoxPuertoL.DataSource = dt;

            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("LOS_QUE_VAN_A_APROBAR.InsertarTramoDeRecorrido", cn))
                {
                    cn.Open();
                    SqlCommand cmd2 = new SqlCommand("select top 1 IdRecorrido from LOS_QUE_VAN_A_APROBAR.Recorrido ORDER BY IdRecorrido Desc", cn);
                    cmd2.CommandType = CommandType.Text;
                    int IdRecorrido = Convert.ToInt32(cmd2.ExecuteScalar());
                    MessageBox.Show(IdRecorrido.ToString());

                    //int IdTramo = Convert.ToInt32(cmd3.ExecuteScalar());
                    
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CodigoRecorrido", IdRecorrido);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Exitosa");
                    cn.Close();
                    cn.Dispose();
                }
            }
        }
        }

        
    }

