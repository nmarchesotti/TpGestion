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
    public partial class ListadoRecorridos : Form
    {
        public ListadoRecorridos()
        {
            InitializeComponent();
            inicializarGrilla();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ABMRecorrido form = new ABMRecorrido();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Dispose();
        }

        private void inicializarGrilla()
        {
            var select = "SELECT CodigoRecorrido, PuertoSalida, PuertoLlegada, CantidadDeTramos, PrecioDeRecorrido FROM LOS_QUE_VAN_A_APROBAR.ListarRecorridos";
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
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {

                Boolean stringModificado = false;
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString))
                {
                    try
                    {
                        string query = "SELECT CodigoRecorrido, PuertoSalida, PuertoLlegada, CantidadDeTramos, PrecioDeRecorrido FROM LOS_QUE_VAN_A_APROBAR.ListarRecorridos where ";

                        if (checkBox1.Checked)
                        {
                            query = query + " (PuertoSalida like '%" + txtPuerto.Text + "%' or  PuertoLlegada like '%" + txtPuerto.Text + "%')";
                            stringModificado = true;
                        }
                        if (checkBox2.Checked)
                        {
                            if (stringModificado)
                            {
                                query = query + " and PrecioDeRecorrido < " + Convert.ToDecimal(txtPrecio.Text);
                            }
                            else
                            {
                                query = query + "PrecioDeRecorrido < " + Convert.ToDecimal(txtPrecio.Text);
                            }
                            stringModificado = true;
                        }

                        if (checkBox3.Checked)
                        {
                            if (stringModificado)
                            {
                                query = query + " and CantidadDeTramos >= " + Convert.ToInt32(txtCantidadPuertos.Text);
                            }
                            else
                            {
                                query = query + "CantidadDeTramos >= " + Convert.ToInt32(txtCantidadPuertos.Text);
                            }
                            stringModificado = true;
                        }

                        if (!stringModificado)
                        {
                            query = "SELECT PuertoSalida, PuertoLlegada, CantidadDeTramos, PrecioDeRecorrido FROM LOS_QUE_VAN_A_APROBAR.ListarRecorridos";
                        }

                        var dataAdapter = new SqlDataAdapter(query, cn);

                        var commandBuilder = new SqlCommandBuilder(dataAdapter);
                        var ds = new DataSet();
                        dataAdapter.Fill(ds);
                        dataGridView1.ReadOnly = true;
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("El precio debe ser un numero positivo y la cantidad de puertos un numero positivo y entero");
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCantidadPuertos.Clear();
            txtPrecio.Clear();
            txtPuerto.Clear();
        }

    }
}
