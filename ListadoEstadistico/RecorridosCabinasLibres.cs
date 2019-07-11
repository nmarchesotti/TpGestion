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

namespace FrbaCrucero.ListadoEstadistico
{
    public partial class RecorridosCabinasLibres : Form
    {
        public RecorridosCabinasLibres()
        {
            InitializeComponent();
            inicializarSemestre();
        }
        private void inicializarSemestre()
        {
            var dataSource = new List<String>();
            dataSource.Add("Primer Semestre");
            dataSource.Add("Segundo Semestre");

            this.comboBoxSemestre.DataSource = dataSource;
            this.comboBoxSemestre.DisplayMember = "Name";

            this.comboBoxSemestre.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListadoEstadistico.MenuListadoEstadistico form = new MenuListadoEstadistico();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Dispose();
        }

        private void comboBoxSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxSemestre.SelectedItem == "Primer Semestre")
            {
                var c = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
                SqlCommand comando = new SqlCommand("", c);

                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;

            }
            else if (comboBoxSemestre.SelectedItem == "Segundo Semestre")
            {
                var c = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
                SqlCommand comando = new SqlCommand("", c);

                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
        }
    }
}
