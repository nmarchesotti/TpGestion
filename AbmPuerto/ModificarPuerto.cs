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
    public partial class ModificarPuerto : Form
    {
        public ModificarPuerto()
        {
            InitializeComponent();
            comboBox1_Load();
        }

        private void btnModificarPuerto_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Debe insertar una descripción para realizar el cambio");
            }
            else
            {

                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("LOS_QUE_VAN_A_APROBAR.ModificarPuerto", cn))
                    {
                        cn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;

                        DataRowView drv2 = (DataRowView)comboBox1.SelectedItem;
                        string puerto = Convert.ToString(drv2["Nombre"]);
                        cmd.Parameters.Add("@NombrePuerto", SqlDbType.NVarChar, 255).Value = puerto;
                        MessageBox.Show(puerto);
                        cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50).Value = textBox2.Text;

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Puerto modificado correctamente");
                        cn.Close();
                        cn.Dispose();
                    }
                    ABMPuerto form = new ABMPuerto();
                    form.StartPosition = FormStartPosition.CenterScreen;
                    form.Show();
                    this.Dispose();
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

            comboBox1.SelectedValue = "Nombre";
            comboBox1.DisplayMember = "Nombre";
            comboBox1.DataSource = dt;
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
