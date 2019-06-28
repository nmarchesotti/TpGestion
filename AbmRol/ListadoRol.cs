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
    public partial class ListadoRol : Form
    {
        public ListadoRol()
        {
            InitializeComponent();
            inicializarGrilla();
        }

        public void inicializarGrilla()
        {
            var select = "SELECT Nombre,Descripcion, Estado FROM LOS_QUE_VAN_A_APROBAR.ListaRoles";
            var c = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuRol form = new MenuRol();
            form.Show();
            this.Dispose();
        }
    }
}
