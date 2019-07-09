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
    public partial class CompraReserva : Form
    {
        public CompraReserva()
        {
            InitializeComponent();
            inicializarGrid();
            comboBoxPuertoL_Load();
            comboBoxPuertoS_Load();
            llenarTipoCabina();
        }

        private void llenarTipoCabina()
        {
            var dataSource = new List<String>();
            dataSource.Add("Suite");
            dataSource.Add("Cabina Balcón");
            dataSource.Add("Cabina estandar");
            dataSource.Add("Ejecutivo");
            dataSource.Add("Cabina Exterior");

            this.comboBoxTipo.DataSource = dataSource;
            this.comboBoxTipo.DisplayMember = "Name";

            this.comboBoxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void inicializarGrid()
        {
            var select = "select * from LOS_QUE_VAN_A_APROBAR.ListarViajesConInfo";
            var c = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
        }


        private void comboBoxPuertoL_Load()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
            cn.Open();
            SqlCommand sc = new SqlCommand("select Nombre from LOS_QUE_VAN_A_APROBAR.Puerto", cn);
            SqlDataReader reader;
            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Nombre", typeof(String));
            dt.Load(reader);

            comboBoxPuertoL.ValueMember = "Nombre";
            comboBoxPuertoL.DisplayMember = "Nombre";
            comboBoxPuertoL.DataSource = dt;

            cn.Close();
        }


        private void comboBoxPuertoS_Load()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
            cn.Open();
            SqlCommand sc = new SqlCommand("select Nombre from LOS_QUE_VAN_A_APROBAR.Puerto", cn);
            SqlDataReader reader;
            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Nombre", typeof(String));
            dt.Load(reader);

            comboBoxPuertoS.ValueMember = "Nombre";
            comboBoxPuertoS.DisplayMember = "Nombre";
            comboBoxPuertoS.DataSource = dt;

            cn.Close();
        }




        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
            cn.Open();
            SqlCommand sc = new SqlCommand("select * from LOS_QUE_VAN_A_APROBAR.ListarViajes(@Fecha_Salida, @Puerto_Salida, @Puerto_Llegada)", cn);
            sc.Parameters.AddWithValue("@Fecha_Salida", Convert.ToDateTime(dateTimePicker1.Text));
            sc.Parameters.AddWithValue("@Puerto_Salida", comboBoxPuertoS.Text);
            sc.Parameters.AddWithValue("@Puerto_Llegada", comboBoxPuertoL.Text);
            SqlDataAdapter adp= new SqlDataAdapter();
            adp.SelectCommand = sc;
            DataTable dataset = new DataTable();
            adp.Fill(dataset);
            BindingSource bsource = new BindingSource();


            bsource.DataSource = dataset;
            dataGridView1.DataSource = bsource;
            adp.Update(dataset);

            comboBoxTipo_Load();

        }

        private void CompraReserva_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
     
        }



        private void comboBoxTipo_Load() {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
            cn.Open();
            SqlCommand sc = new SqlCommand("select TipoServicio from LOS_QUE_VAN_A_APROBAR.Servicio", cn);
            SqlDataReader reader;
            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TipoServicio", typeof(String));
            dt.Load(reader);

            comboBoxTipo.ValueMember = "TipoServicio";
            comboBoxTipo.DisplayMember = "TipoServicio";
            comboBoxTipo.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PantallaInicial.Inicio form = new PantallaInicial.Inicio();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Dispose();
        }


    }
}
