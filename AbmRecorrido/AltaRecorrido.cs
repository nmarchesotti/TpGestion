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
    public partial class AltaRecorrido : Form
    {
        public AltaRecorrido()
        {
            InitializeComponent();
        }

        private void btnAltaRecorrido_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("LOS_QUE_VAN_A_APROBAR.CrearRecorrido", cn))
                {
                    cn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@CodigoRecorrido", SqlDbType.Decimal).Value = Decimal.Parse(CodigoRecorrido.Text);
                    cmd.Parameters["@CodigoRecorrido"].Precision = 18;
                    cmd.Parameters["@CodigoRecorrido"].Scale = 2;

                    cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50).Value = DescripcionRecorrido.Text;

                    cmd.Parameters.Add("@Precio", SqlDbType.Decimal).Value = Decimal.Parse(PrecioRecorrido.Text);
                    cmd.Parameters["@Precio"].Precision = 18;
                    cmd.Parameters["@Precio"].Scale = 2;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Nuevo recorrido satisfactorio");
                    cn.Close();
                    cn.Dispose();
                }
            }

            AgregarTramo form = new AgregarTramo((Decimal.Parse(PrecioRecorrido.Text)));
            form.Show();
            form.StartPosition = FormStartPosition.CenterScreen;
            this.Dispose();
        }

        private void btnMenuRecorrido_Click(object sender, EventArgs e)
        {
            ABMRecorrido form = new ABMRecorrido();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Dispose();
        }
    }
}
