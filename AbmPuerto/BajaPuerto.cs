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

namespace FrbaCrucero.AbmPuerto
{
    public partial class BajaPuerto : Form
    {
        public BajaPuerto()
        {
            InitializeComponent();
            comboBox1_Load();
        }

        private void btnBajaPuerto_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("LOS_QUE_VAN_A_APROBAR.EliminarPuerto", cn))
                {
                    cn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    DataRowView drv2 = (DataRowView)comboBoxPuertos.SelectedItem;
                    string puerto = Convert.ToString(drv2["Nombre"]);
                    cmd.Parameters.Add("@NombrePuertoBorrado", SqlDbType.NVarChar, 255).Value = puerto;
                    MessageBox.Show(puerto);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Exitosa");
                    cn.Close();
                    cn.Dispose();
                }
            }
        }
            
        private void comboBox1_Load()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
            cn.Open();
            SqlCommand sc = new SqlCommand("select Nombre from LOS_QUE_VAN_A_APROBAR.Puerto", cn);
            SqlDataReader reader;
            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Nombre", typeof(string));
            dt.Load(reader);

            comboBoxPuertos.SelectedValue = "Nombre";
            comboBoxPuertos.DisplayMember = "Nombre";
            comboBoxPuertos.DataSource = dt;
            cn.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            ABMPuerto form = new ABMPuerto();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Dispose();
        }
        
    }
}
