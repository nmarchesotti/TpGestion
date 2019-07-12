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
    public partial class NuevoTramo : Form
    {
        string PuertoSalida;
        string PuertoLlegada;

        public NuevoTramo(string ps, string pl)
        {
            PuertoSalida = ps;
            PuertoLlegada = pl;
            InitializeComponent();
        }

        private void NuevoTramo_Load(object sender, EventArgs e)
        {
            textBoxPuertoL.Text = PuertoLlegada;
            textBoxPuertoS.Text = PuertoSalida;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand("LOS_QUE_VAN_A_APROBAR.InsertarTramo", cn))
                {
                    cn.Open();

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@PuertoSalida", SqlDbType.NVarChar, 255).Value = PuertoSalida;
                    cmd.Parameters.Add("@PuertoLlegada", SqlDbType.NVarChar, 255).Value = PuertoLlegada;
                    cmd.Parameters.Add("@Precio", SqlDbType.Decimal).Value = Convert.ToDecimal(textBoxPrecio.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Tramo agregado satisfactoriamente");

                    cn.Close();
                    cn.Dispose();
                }
            }

            this.Dispose();
        }

    }
}
