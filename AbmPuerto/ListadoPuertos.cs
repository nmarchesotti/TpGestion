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

namespace FrbaCrucero.AbmPuerto
{
    public partial class ListadoPuertos : Form
    {
        public ListadoPuertos()
        {
            InitializeComponent();
            inicializarLista();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ABMPuerto form = new ABMPuerto();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Dispose();
        }

        private void inicializarLista()
        {
            var select = "SELECT Nombre,Descripcion FROM LOS_QUE_VAN_A_APROBAR.Puerto";
            var c = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var select = ("SELECT Nombre,Descripcion FROM LOS_QUE_VAN_A_APROBAR.Puerto where Nombre like '%" + textBox1.Text + "%'");
            var c = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
