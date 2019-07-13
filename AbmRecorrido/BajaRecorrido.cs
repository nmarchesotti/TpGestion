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
    public partial class BajaRecorrido : Form
    {
        public BajaRecorrido()
        {
            InitializeComponent();
            comboBoxReco_Load();
        }
        private void comboBoxReco_Load()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
            cn.Open();
            SqlCommand sc = new SqlCommand("select IdRecorrido from LOS_QUE_VAN_A_APROBAR.Recorrido where Estado = 'Habilitado'", cn);
            SqlDataReader reader;
            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("IdRecorrido", typeof(int));
            dt.Load(reader);

            comboBoxReco.SelectedValue = "IdRecorrido";
            comboBoxReco.DisplayMember = "IdRecorrido";
            comboBoxReco.DataSource = dt;
            cn.Close();
        }

        private void btnBajaRecorrido_Click(object sender, EventArgs e)
        {

            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("select LOS_QUE_VAN_A_APROBAR.VerificarBajaRecorrido(@IdRecorrido)", cn))
                {
                    cn.Open();
                    cmd.CommandType = CommandType.Text;

                    DataRowView drv2 = (DataRowView)comboBoxReco.SelectedItem;
                    int reco = Convert.ToInt32(drv2["IdRecorrido"]);
                    cmd.Parameters.Add("@IdRecorrido", SqlDbType.Int).Value = reco;


                    // ver como hacer cuando hay un viaje con ese recorrido

                    int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                    if (resultado == 1)
                    {                        
                        SqlCommand cmd2 = new SqlCommand("LOS_QUE_VAN_A_APROBAR.InhabilitarRecorrido", cn);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.Add("@IdRecorrido", SqlDbType.Int).Value = reco;
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("El recorrido fue inhabilitado correctamente");
                    }
                    else if (resultado == 0)
                    {
                        MessageBox.Show("El recorrido no fue eliminado debido a que tiene viajes pendientes");
                    }

                }

                
            }
            
            ABMRecorrido form = new ABMRecorrido();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ABMRecorrido form = new ABMRecorrido();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Dispose();
        }


    }
}
