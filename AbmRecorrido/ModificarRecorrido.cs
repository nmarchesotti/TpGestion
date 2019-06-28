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
    public partial class ModificarRecorrido : Form
    {
        

        public ModificarRecorrido()
        {
            
            InitializeComponent();
            comboBoxReco_Load();
            comboBoxPuertoS_Load();
            comboBoxPuertoL_Load();
            
         
        }

        private void comboBoxReco_Load()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
            cn.Open();
            SqlCommand sc = new SqlCommand("select IdRecorrido, Codigo_Recorrido from LOS_QUE_VAN_A_APROBAR.Recorrido", cn);
            SqlDataReader reader;
            reader = sc.ExecuteReader();
            DataTable dtb = new DataTable();
            dtb.Columns.Add("IdRecorrido", typeof(int));
            dtb.Columns.Add("Codigo_Recorrido", typeof(string));
            dtb.Load(reader);


            
            comboBoxModifReco.ValueMember = "IdRecorrido";
            comboBoxModifReco.DisplayMember = "Codigo_Recorrido";
            comboBoxModifReco.DataSource = dtb;
            cn.Close();
        }



        private void comboBoxTramos_Load()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
            cn.Open();
            //SqlCommand sc = new SqlCommand("select CodigoTramo, Puertos from LOS_QUE_VAN_A_APROBAR.tramosDeRecorrido(@IdRecorrido)", cn);
            SqlCommand sc = new SqlCommand("select r.CodigoTramo, t.Puerto_Salida ++ ' - ' ++ t.Puerto_Llegada as Puertos from LOS_QUE_VAN_A_APROBAR.Tramo t join LOS_QUE_VAN_A_APROBAR.RecorridoPorTramo r ON (r.CodigoTramo = t.IdTramo) where r.CodigoRecorrido = @IdRecorrido", cn);
            sc.Parameters.AddWithValue("@IdRecorrido", Convert.ToInt32(comboBoxModifReco.SelectedValue.ToString()));
            SqlDataReader reader;
            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CodigoTramo", typeof(int));
            dt.Columns.Add("Puertos", typeof(string));
            dt.Load(reader);

            comboBoxTramos.ValueMember = "CodigoTramo";
            comboBoxTramos.DisplayMember = "Puertos";
            comboBoxTramos.DataSource = dt;
            cn.Close();
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

        private void btnCambiarTramo_Click(object sender, EventArgs e)
        {
         
            
           
            comboBoxTramos_Load();
        

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("LOS_QUE_VAN_A_APROBAR.modificarTramoDeRecorrido", cn))
                {
                    cn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdRecorrido", Convert.ToInt32(comboBoxModifReco.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@TramoViejo", Convert.ToInt32(comboBoxTramos.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@Puerto_Salida", comboBoxPuertoS.Text);
                    cmd.Parameters.AddWithValue("@Puerto_Llegada", comboBoxPuertoL.Text);

                    

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Exitosa");
                    cn.Close();
                    cn.Dispose();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ABMRecorrido form = new ABMRecorrido();
            form.Show();
            this.Dispose();
        }




    }
}
