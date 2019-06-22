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

namespace FrbaCrucero.AbmCrucero
{
    public partial class AltaCrucero : Form
    {
        public AltaCrucero()
        {
            InitializeComponent();
            comboBoxMarca_Load();
            comboBoxModelo_Load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ABMCrucero form = new ABMCrucero();
            form.Show();
            this.Dispose();
        }

        private void comboBoxModelo_Load(){

            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
            cn.Open();
            SqlCommand sc = new SqlCommand("select IdModelo, Descripcion from LOS_QUE_VAN_A_APROBAR.Modelo", cn);
            SqlDataReader reader;
            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("IdModelo", typeof(int));
            dt.Columns.Add("Descripcion", typeof(string));
            dt.Load(reader);

            comboBoxModelo.SelectedValue = "Descripcion";
            comboBoxModelo.DisplayMember = "Descripcion";
            comboBoxModelo.DataSource = dt;
            cn.Close();
        }

        private void comboBoxMarca_Load()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
            cn.Open();
            SqlCommand sc = new SqlCommand("select IdMarca, Descripcion from LOS_QUE_VAN_A_APROBAR.Marca", cn);
            SqlDataReader reader;
            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("IdMarca", typeof(int));
            dt.Columns.Add("Descripcion", typeof(string));
            dt.Load(reader);

            comboBoxMarca.ValueMember = "Descripcion";
            comboBoxMarca.DisplayMember = "Descripcion";
            comboBoxMarca.DataSource = dt;
            cn.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("LOS_QUE_VAN_A_APROBAR.AltaCrucero", cn))
                {
                    cn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@IdCrucero", SqlDbType.NVarChar, 50).Value = txtNombreCrucero.Text;

                    DataRowView drv = (DataRowView) comboBoxMarca.SelectedItem;
                    int marca = Convert.ToInt32(drv["IdMarca"]);
                    cmd.Parameters.Add("@IdMarca", SqlDbType.Int).Value = marca;
                    MessageBox.Show(Convert.ToString(marca));

                    DataRowView drv2 = (DataRowView) comboBoxModelo.SelectedItem;
                    int modelo = Convert.ToInt32(drv2["IdModelo"]);
                    cmd.Parameters.Add("@IdModelo", SqlDbType.Int).Value = modelo;
                    MessageBox.Show(Convert.ToString(modelo));

                    cmd.Parameters.Add("@CantidadCabinas", SqlDbType.Int).Value = txtCantidadCabinas.Text;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Exitosa");
                    cn.Close();
                    cn.Dispose();
                }

            }
        }
    }
}
