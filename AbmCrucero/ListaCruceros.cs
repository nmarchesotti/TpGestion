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
        }
        
        private void inicializarLista()
        {
            var select = "SELECT * FROM LOS_QUE_VAN_A_APROBAR.ListarCruceros";
            var c = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString); // Your Connection String here
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
        }
    }
