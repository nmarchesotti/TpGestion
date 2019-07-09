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

namespace FrbaCrucero.GeneracionViaje
{
    public partial class ListadoViajes : Form
    {
        public ListadoViajes()
        {
            InitializeComponent();
            cargarLista();
            cargarComboBox1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuViaje form = new MenuViaje();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Dispose();
        }

        private void cargarComboBox1()
        {
            var dataSource = new List<String>();
            dataSource.Add("Viajes finalizados");
            dataSource.Add("Viajes en curso");
            dataSource.Add("Viajes pendientes");

            this.comboBox1.DataSource = dataSource;
            this.comboBox1.DisplayMember = "Name";

            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cargarLista()
        {
            var select = "SELECT * FROM LOS_QUE_VAN_A_APROBAR.ListarTodosLosViajes order by NumeroDeViaje DESC";
            var c = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[4].Width = 290;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

                if (comboBox1.SelectedItem == "Viajes finalizados")
                {
                    var select = "SELECT * FROM LOS_QUE_VAN_A_APROBAR.ListarTodosLosViajes where Fecha_Llegada < (select TOP(1) Fecha from LOS_QUE_VAN_A_APROBAR.TablaFecha) order by NumeroDeViaje DESC";
                    var c = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
                    var dataAdapter = new SqlDataAdapter(select, c);

                    var commandBuilder = new SqlCommandBuilder(dataAdapter);
                    var ds = new DataSet();
                    dataAdapter.Fill(ds);
                    dataGridView1.ReadOnly = true;
                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.Columns[4].Width = 290;
                }
                else if (comboBox1.SelectedItem == "Viajes en curso")
                {
                    var select = "SELECT * FROM LOS_QUE_VAN_A_APROBAR.ListarTodosLosViajes where (select TOP(1) Fecha from LOS_QUE_VAN_A_APROBAR.TablaFecha) between Fecha_Salida and Fecha_Llegada order by NumeroDeViaje DESC";
                    var c = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
                    var dataAdapter = new SqlDataAdapter(select, c);

                    var commandBuilder = new SqlCommandBuilder(dataAdapter);
                    var ds = new DataSet();
                    dataAdapter.Fill(ds);
                    dataGridView1.ReadOnly = true;
                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.Columns[4].Width = 290;
                }
                else if (comboBox1.SelectedItem == "Viajes pendientes")
                {
                    var select = "SELECT * FROM LOS_QUE_VAN_A_APROBAR.ListarTodosLosViajes where Fecha_Salida > (select TOP(1) Fecha from LOS_QUE_VAN_A_APROBAR.TablaFecha) order by NumeroDeViaje DESC";
                    var c = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
                    var dataAdapter = new SqlDataAdapter(select, c);

                    var commandBuilder = new SqlCommandBuilder(dataAdapter);
                    var ds = new DataSet();
                    dataAdapter.Fill(ds);
                    dataGridView1.ReadOnly = true;
                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.Columns[4].Width = 290;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var select = "SELECT * FROM LOS_QUE_VAN_A_APROBAR.ListarTodosLosViajes order by NumeroDeViaje DESC";
            var c = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[4].Width = 290;
        }
    }
}
