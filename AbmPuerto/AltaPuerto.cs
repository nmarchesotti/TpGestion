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
    public partial class AltaPuerto : Form
    {
        public AltaPuerto()
        {
            InitializeComponent();
        }

        private void AltaPuerto_Load(object sender, EventArgs e)
        {

        }

        private void NombreDelPuerto(object sender, EventArgs e)
        {

        }

        private void btnAltaPuerto_Click(object sender, EventArgs e)
        {


            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("LOS_QUE_VAN_A_APROBAR.CrearPuerto", cn))
                {
                    cn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@NombrePuerto", SqlDbType.NVarChar, 255).Value = NombrePuerto.Text;
                    cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50).Value = DescripcionPuerto.Text;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Exitosa");
                    cn.Close();
                    cn.Dispose();
                }
            }
            
            
            
            
            /*SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
            SqlCommand cmd = new SqlCommand("LOS_QUE_VAN_A_APROBAR.CrearPuerto", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@NombrePuerto", SqlDbType.NVarChar, 255).Value = NombrePuerto.Text.ToString();
            cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50).Value = Descripcion.Text.ToString();

            try
            {

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Exitosa");
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cn.Close();
                cn.Dispose();

            }*/

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ABMPuerto form = new ABMPuerto();
            form.Show();
            this.Dispose();
        }
    }
}
