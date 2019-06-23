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
    public partial class ListaCruceros : Form
    {
        public ListaCruceros()
        {
            InitializeComponent();
            inicializarLista();
            inicializarFiltros();
        }
        
        private void inicializarLista()
        {
            var select = "SELECT * FROM LOS_QUE_VAN_A_APROBAR.ListarCruceros";
            var c = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString); 
            var dataAdapter = new SqlDataAdapter(select, c); 

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true; 
            dataGridView1.DataSource = ds.Tables[0];

            }

        private void button2_Click(object sender, EventArgs e)
        {
            ABMCrucero form = new ABMCrucero();
            form.Show();
            this.Dispose();
        }

        private void inicializarFiltros()
        {
            var dataSource = new List<String>();
            dataSource.Add("Cruceros habilitados");
            dataSource.Add("Cruceros fuera de servicio");

            this.comboBox1.DataSource = dataSource;
            this.comboBox1.DisplayMember = "Name";

            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Cruceros habilitados")
            {
                var select = "SELECT * FROM LOS_QUE_VAN_A_APROBAR.ListarCrucerosHabilitados";
                var c = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
                var dataAdapter = new SqlDataAdapter(select, c);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if(comboBox1.SelectedItem == "Cruceros fuera de servicio")
            {
                var select = "SELECT * FROM LOS_QUE_VAN_A_APROBAR.ListarCrucerosInhabilitados";
                var c = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
                var dataAdapter = new SqlDataAdapter(select, c);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
        }
    }
