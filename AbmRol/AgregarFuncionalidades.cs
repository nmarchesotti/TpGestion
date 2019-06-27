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

namespace FrbaCrucero.AbmRol
{
    public partial class AgregarFuncionalidades : Form
    {
        public AgregarFuncionalidades()
        {
            InitializeComponent();
            cargarRoles();
            cargarCheckedList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EleccionDeModificacion form = new EleccionDeModificacion();
            form.Show();
            this.Dispose();

        }

        private void cargarRoles()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
            cn.Open();
            SqlCommand sc = new SqlCommand("select IdRol, Nombre from LOS_QUE_VAN_A_APROBAR.Rol where Estado = 'Habilitado'", cn);
            SqlDataReader reader;
            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("IdRol", typeof(Int32));
            dt.Load(reader);

            comboBox1.ValueMember = "IdRol";
            comboBox1.DisplayMember = "Nombre";
            comboBox1.DataSource = dt;
            cn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString))
            {
                cn.Open();
               
                using (SqlCommand cmd2 = new SqlCommand("LOS_QUE_VAN_A_APROBAR.BajaFuncionalidadesDelRol", cn))
                {
                    cmd2.CommandType = CommandType.StoredProcedure;
                    DataRowView drv = (DataRowView)comboBox1.SelectedItem;
                    int idRol = Convert.ToInt32(drv["IdRol"]);
                    cmd2.Parameters.Add("@IdRol", SqlDbType.Int).Value = idRol;
                    cmd2.ExecuteNonQuery();

                    using (SqlCommand cmd3 = new SqlCommand("LOS_QUE_VAN_A_APROBAR.AltaFuncionalidadDelRol", cn))
                    {
                        cmd3.CommandType = CommandType.StoredProcedure;
                        cmd3.Parameters.Add("@IdRol", SqlDbType.Int).Value = idRol;
                        cmd3.Parameters.Add("@IdFuncionalidad", SqlDbType.Int);
                        DataRow row;
                        for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                        {
                            row = ((((DataRowView)checkedListBox1.CheckedItems[i]))).Row;
                            int valor = Convert.ToInt32(row[checkedListBox1.ValueMember]);
                            cmd3.Parameters["@IdFuncionalidad"].Value = valor;
                            cmd3.ExecuteNonQuery();

                        }
                        MessageBox.Show("Exitosa");

                    }

                }

                cn.Close();
                cn.Dispose();

            }
        }


        private void cargarCheckedList() {
            {
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString))
                {

                    using (SqlCommand cmd = new SqlCommand("select IdFuncionalidad, Descripcion from LOS_QUE_VAN_A_APROBAR.Funcionalidad", cn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            ((ListBox)checkedListBox1).DataSource = dt;
                            ((ListBox)checkedListBox1).DisplayMember = "Descripcion";
                            ((ListBox)checkedListBox1).ValueMember = "IdFuncionalidad";
                        }
                    }
                }
            }
        }
    }
}
