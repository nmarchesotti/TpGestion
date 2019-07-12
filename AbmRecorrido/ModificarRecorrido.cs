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
            comboBoxPuertoL_Load();
            comboBoxS_Load();
            
         
        }

        private void comboBoxReco_Load()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
            cn.Open();
            SqlCommand sc = new SqlCommand("select distinct r.IdRecorrido, r.Codigo_Recorrido from LOS_QUE_VAN_A_APROBAR.RecorridoPorTramo t join LOS_QUE_VAN_A_APROBAR.Recorrido r ON (r.IdRecorrido = t.CodigoRecorrido)", cn);
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
            MessageBox.Show(comboBoxModifReco.SelectedValue.ToString());
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

        private void comboBoxS_Load()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
            cn.Open();
            SqlCommand sc = new SqlCommand("select Nombre from LOS_QUE_VAN_A_APROBAR.Puerto", cn);
            SqlDataReader reader;
            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Nombre", typeof(String));
            dt.Load(reader);

            comboBoxS.ValueMember = "Nombre";
            comboBoxS.DisplayMember = "Nombre";
            comboBoxS.DataSource = dt;

            cn.Close();
        }

        private void btnCambiarTramo_Click(object sender, EventArgs e)
        {
         
            
           
            
        

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxS.Text == "" || comboBoxPuertoL.Text == "")
            {
                MessageBox.Show("Debe especificar ambos puertos");
            }
            else
            {

                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString))
                {
                    cn.Open();

                    SqlCommand com = new SqlCommand("select LOS_QUE_VAN_A_APROBAR.ExisteTramo(@PuertoSalida, @PuertoLlegada)", cn);
                    com.CommandType = CommandType.Text;

                    com.Parameters.Add("@PuertoSalida", SqlDbType.NVarChar, 255).Value = comboBoxS.Text;
                    com.Parameters.Add("@PuertoLlegada", SqlDbType.NVarChar, 255).Value = comboBoxPuertoL.Text;

                    int res = Convert.ToInt32(com.ExecuteScalar());

                    if (res == 1)
                    {

                        MessageBox.Show("El tramo no existe, por favor ingrese un precio y vuelva a intentarlo");
                        NuevoTramo n = new NuevoTramo(comboBoxS.Text, comboBoxPuertoL.Text);
                        n.Show();

                    }
                    else
                    {
                        using (SqlCommand cmd = new SqlCommand("LOS_QUE_VAN_A_APROBAR.modificarTramoDeRecorrido", cn))
                        {
                            try
                            {

                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@CodigoRecorrido", Convert.ToInt32(comboBoxModifReco.SelectedValue.ToString()));
                                cmd.Parameters.AddWithValue("@IdTramo", Convert.ToInt32(comboBoxTramos.SelectedValue.ToString()));
                                cmd.Parameters.AddWithValue("@PuertoSalida", comboBoxS.Text);
                                cmd.Parameters.AddWithValue("@PuertoLlegada", comboBoxPuertoL.Text);



                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Tramo de recorrido modificado exitosamente");
                                cn.Close();
                                cn.Dispose();
                            }
                            catch
                            {
                                MessageBox.Show("INGRESE EL MISMO PUERTO DE SALIDA");
                            }
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ABMRecorrido form = new ABMRecorrido();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Dispose();
        }

        private void comboBoxPuertoS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxModifReco_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBoxTramos_Load();
        }

        private void comboBoxTramos_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }




    }
}
