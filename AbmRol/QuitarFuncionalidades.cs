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
    public partial class QuitarFuncionalidades : Form
    {
        public QuitarFuncionalidades()
        {
            InitializeComponent();
            cargarComboBox();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EleccionDeModificacion form = new EleccionDeModificacion();
            form.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString))
            {
                cn.Open();
                DataRowView drv = (DataRowView)comboBox1.SelectedItem;
                int idRol = Convert.ToInt32(drv["IdRol"]);
                MessageBox.Show(idRol.ToString());

                using (SqlCommand cmd = new SqlCommand("LOS_QUE_VAN_A_APROBAR.BajaFuncionalidadDeRol", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@IdRol", SqlDbType.Int).Value = idRol;
                    cmd.Parameters.Add("@IdFuncionalidad", SqlDbType.Int);
                    DataRow row;

                    for (int i = 0; i< checkedListBox1.CheckedItems.Count;i++){

                        row = ((((DataRowView)checkedListBox1.CheckedItems[i]))).Row;
                        int valor = Convert.ToInt32(row[checkedListBox1.ValueMember]);
                        cmd.Parameters["@IdFuncionalidad"].Value = valor;
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Exitosa");
                }
                cn.Close();
                cn.Dispose();

            }
        }

        private void cargarCheckList()
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString))
                {
                    DataRowView drv = (DataRowView)comboBox1.SelectedItem;
                    int idRol = Convert.ToInt32(drv["IdRol"]);

                    using (SqlCommand cmd = new SqlCommand("select F.IdFuncionalidad, F.Descripcion from LOS_QUE_VAN_A_APROBAR.FuncionalidadPorRol FPR join LOS_QUE_VAN_A_APROBAR.Funcionalidad F on F.IdFuncionalidad = FPR.IdFuncionalidad where FPR.IdRol = " + idRol + " and Estado = 'Habilitado'", cn))
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

                    cn.Close();
                cn.Dispose();
                }
            }

        

        private void cargarComboBox()
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
            cn.Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCheckList();
        }
    }
}
