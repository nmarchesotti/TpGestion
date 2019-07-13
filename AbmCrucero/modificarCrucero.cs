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
    public partial class modificarCrucero : Form
    {
        public modificarCrucero()
        {
            InitializeComponent();
            comboBoxIdCrucero_Load();
            comboBoxMarca_Load();
            comboBoxModelo_Load();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            ABMCrucero form = new ABMCrucero();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Dispose();
        }

        private void comboBoxIdCrucero_Load()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
            cn.Open();
            SqlCommand sc = new SqlCommand("select IdCrucero from LOS_QUE_VAN_A_APROBAR.ListarCrucerosHabilitados", cn);
            SqlDataReader reader;
            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("IdCrucero", typeof(string));
            dt.Load(reader);

            comboBoxIdCrucero.SelectedValue = "IdCrucero";
            comboBoxIdCrucero.DisplayMember = "IdCrucero";
            comboBoxIdCrucero.DataSource = dt;
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

        private void comboBoxModelo_Load()
        {
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


        private void button1_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("LOS_QUE_VAN_A_APROBAR.ModificarMarcaYModelo", cn))
                {
                    cn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    DataRowView drv2 = (DataRowView)comboBoxIdCrucero.SelectedItem;
                    string idCrucero = Convert.ToString(drv2["IdCrucero"]);
                    cmd.Parameters.Add("@IdCrucero", SqlDbType.NVarChar, 50).Value = idCrucero;

                    DataRowView drv = (DataRowView)comboBoxMarca.SelectedItem;
                    int marca = Convert.ToInt32(drv["IdMarca"]);
                    cmd.Parameters.Add("@IdMarca", SqlDbType.Int).Value = marca;

                    DataRowView drv3 = (DataRowView)comboBoxModelo.SelectedItem;
                    int modelo = Convert.ToInt32(drv3["IdModelo"]);
                    cmd.Parameters.Add("@IdModelo", SqlDbType.Int).Value = modelo;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Crucero modificado correctamente");
                    cn.Close();
                    cn.Dispose();
                    this.Dipose();
                }
            }

        }

    }
}
