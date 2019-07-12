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

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class InformacionReserva : Form
    {
        int idviaje;
        int idcliente;


        public InformacionReserva(int c, int v)
        {
            InitializeComponent();
            idcliente = c;
            idviaje = v;
            grid_load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grid_load()
        {

            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
            cn.Open();
            SqlCommand sc = new SqlCommand("select * from LOS_QUE_VAN_A_APROBAR.InformacionReserva(@IdCliente, @IdViaje)", cn);
            sc.Parameters.AddWithValue("@IdCliente", idcliente);
            sc.Parameters.AddWithValue("@IdViaje", idviaje);
            
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = sc;
            DataTable dataset = new DataTable();
            adp.Fill(dataset);
            BindingSource bsource = new BindingSource();


            bsource.DataSource = dataset;
            dataGridView1.DataSource = bsource;
            adp.Update(dataset);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            PantallaInicial.Inicio form = new PantallaInicial.Inicio();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Dispose();
        }
    }
}
