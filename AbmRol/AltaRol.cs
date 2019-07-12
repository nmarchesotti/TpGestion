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

namespace FrbaCrucero.AbmRol
{
    public partial class AltaRol : Form
    {
        public AltaRol()
        {
            InitializeComponent();
            cargarComboBox();
        }

        private void cargarComboBox()
        {

            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
            cn.Open();
            SqlCommand sc = new SqlCommand("select Nombre from LOS_QUE_VAN_A_APROBAR.Rol where Estado = 'Inhabilitado'", cn);
            SqlDataReader reader;
            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Nombre", typeof(string));
            dt.Load(reader);

            comboBox1.ValueMember = "Nombre";
            comboBox1.DisplayMember = "Nombre";
            comboBox1.DataSource = dt;
            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("LOS_QUE_VAN_A_APROBAR.AltaRol", cn))
                {
                    cn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataRowView drv = (DataRowView)comboBox1.SelectedItem;
                    String valueOfItem = drv["Nombre"].ToString();
                    cmd.Parameters.Add("@IdRol", SqlDbType.NVarChar, 20).Value = valueOfItem;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rol activado exitosamente");
                    cn.Close();
                    cn.Dispose();
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuRol form = new MenuRol();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Dispose();
        }
    }
}
