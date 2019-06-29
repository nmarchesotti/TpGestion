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
    public partial class InfoRecorridos : Form
    {
        public InfoRecorridos()
        {
            InitializeComponent();
            inicializarComboBox();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ABMRecorrido form = new ABMRecorrido();
            form.Show();
            form.StartPosition = FormStartPosition.CenterScreen;
            this.Dispose();
        }

        private void inicializarComboBox()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
            cn.Open();
            SqlCommand sc = new SqlCommand("select IdRecorrido, Codigo_Recorrido from LOS_QUE_VAN_A_APROBAR.Recorrido", cn);
            SqlDataReader reader;
            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("IdRecorrido", typeof(int));
            dt.Columns.Add("Codigo_Recorrido", typeof(string));
            dt.Load(reader);

            comboBoxReco.SelectedValue = "IdRecorrido";
            comboBoxReco.DisplayMember = "IdRecorrido";
            comboBoxReco.DataSource = dt;
            cn.Close();
        }

        private void comboBoxReco_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString))
            {
                DataRowView drv2 = (DataRowView)comboBoxReco.SelectedItem;
                int IdReco = Convert.ToInt32(drv2["IdRecorrido"]);

                string cmd1 = "select DISTINCT p.Nombre from LOS_QUE_VAN_A_APROBAR.Puerto p join LOS_QUE_VAN_A_APROBAR.Tramo T on (T.Puerto_Llegada = p.Nombre or T.Puerto_Salida = p.Nombre) join LOS_QUE_VAN_A_APROBAR.RecorridoPorTramo RPT on T.IdTramo = RPT.CodigoTramo where RPT.CodigoRecorrido =" + IdReco ;


                using (SqlCommand cmd = new SqlCommand(cmd1, cn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
                


                
            }
        }
    }
}
