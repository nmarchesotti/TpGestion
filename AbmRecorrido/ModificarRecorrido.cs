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
            
            
         
        }

        private void comboBoxReco_Load()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
            cn.Open();
            SqlCommand sc = new SqlCommand("select distinct r.IdRecorrido, r.Codigo_Recorrido from LOS_QUE_VAN_A_APROBAR.RecorridoPorTramo t join LOS_QUE_VAN_A_APROBAR.Recorrido r ON (r.IdRecorrido = t.CodigoRecorrido) where r.estado = 'Habilitado'", cn);
            SqlDataReader reader;
            reader = sc.ExecuteReader();
            DataTable dtb = new DataTable();
            dtb.Columns.Add("IdRecorrido", typeof(int));
            dtb.Load(reader);


            
            comboBoxModifReco.ValueMember = "IdRecorrido";
            comboBoxModifReco.DisplayMember = "IdRecorrido";
            comboBoxModifReco.DataSource = dtb;
            cn.Close();
        }



        private void comboBoxTramos_Load()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
            cn.Open();
            //SqlCommand sc = new SqlCommand("select CodigoTramo, Puertos from LOS_QUE_VAN_A_APROBAR.tramosDeRecorrido(@IdRecorrido)", cn);
            SqlCommand sc = new SqlCommand("select rpt.CodigoTramo, t.Puerto_Salida ++ ' - ' ++ t.Puerto_Llegada as Puertos from LOS_QUE_VAN_A_APROBAR.Tramo t join LOS_QUE_VAN_A_APROBAR.RecorridoPorTramo rpt ON (rpt.CodigoTramo = t.IdTramo) where rpt.CodigoRecorrido = @IdRecorrido ", cn);
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



        

        
        private void btnCambiarTramo_Click(object sender, EventArgs e)
        {
         
            
           
            
        

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ABMRecorrido form = new ABMRecorrido();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Dispose();
        }



        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void comboBoxTramos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            comboBoxTramos_Load();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
            cn.Open();
            SqlCommand sc = new SqlCommand("select top 1 Puerto_Llegada from LOS_QUE_VAN_A_APROBAR.RecorridoPorTramo join LOS_QUE_VAN_A_APROBAR.Tramo on (IdTramo = CodigoTramo) where CodigoRecorrido = @IdRecorrido order by orden desc ", cn);

            sc.CommandType = CommandType.Text;
            
            sc.Parameters.AddWithValue("@IdRecorrido", Convert.ToInt32(comboBoxModifReco.SelectedValue.ToString()));

            string PuertoS =sc.ExecuteScalar().ToString();



            cn.Close();

            AgregarTramo fo = new AgregarTramo(Convert.ToInt32(comboBoxModifReco.SelectedValue.ToString()), PuertoS);
            fo.Show();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
            cn.Open();
            SqlCommand sc = new SqlCommand("LOS_QUE_VAN_A_APROBAR.EliminarUltimoTramo", cn);

            sc.CommandType = CommandType.StoredProcedure;

            sc.Parameters.AddWithValue("@IdRecorrido", Convert.ToInt32(comboBoxModifReco.SelectedValue.ToString()));

            sc.ExecuteNonQuery();

            MessageBox.Show("Ultimo tramo del recorrido eliminado con éxito");
            

            cn.Close();
            cn.Dispose();

            comboBoxTramos_Load();
        }





    }
}
