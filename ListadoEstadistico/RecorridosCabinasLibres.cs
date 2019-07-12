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
                SqlCommand comando = new SqlCommand("SELECT TOP 5 r1.IdRecorrido, (select sum(rpt1.PrecioTramo) as PrecioTotal from LOS_QUE_VAN_A_APROBAR.RecorridoPorTramo rpt1 where (rpt1.CodigoRecorrido = r1.IdRecorrido)) as PrecioTotal, v1.IdViaje, v1.Fecha_Salida, c1.IdCrucero, (c1.CantidadCabinas - (select count(p1.IdPasaje)  from LOS_QUE_VAN_A_APROBAR.Pasaje p1 where (p1.IdViaje = v1.IdViaje))) as CantidadCabinasLibres from LOS_QUE_VAN_A_APROBAR.Recorrido r1 join LOS_QUE_VAN_A_APROBAR.Viaje v1 on (r1.IdRecorrido = v1.IdRecorrido) join LOS_QUE_VAN_A_APROBAR.Crucero c1 on (v1.IdCrucero = c1.IdCrucero) where MONTH(v1.Fecha_Salida) <= 6 AND YEAR(v1.Fecha_Salida)= " + int.Parse(txtAnio.Text) + @"
                                                        order by CantidadCabinasLibres DESC", c);

                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;

            }
            else if (comboBoxSemestre.SelectedItem == "Segundo Semestre")
            {
                var c = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
                SqlCommand comando = new SqlCommand("SELECT TOP 5 r1.IdRecorrido, (select sum(rpt1.PrecioTramo) as PrecioTotal from LOS_QUE_VAN_A_APROBAR.RecorridoPorTramo rpt1 where (rpt1.CodigoRecorrido = r1.IdRecorrido)) as PrecioTotal, v1.IdViaje, v1.Fecha_Salida, c1.IdCrucero, (c1.CantidadCabinas - (select count(p1.IdPasaje)  from LOS_QUE_VAN_A_APROBAR.Pasaje p1 where (p1.IdViaje = v1.IdViaje))) as CantidadCabinasLibres from LOS_QUE_VAN_A_APROBAR.Recorrido r1 join LOS_QUE_VAN_A_APROBAR.Viaje v1 on (r1.IdRecorrido = v1.IdRecorrido) join LOS_QUE_VAN_A_APROBAR.Crucero c1 on (v1.IdCrucero = c1.IdCrucero) where MONTH(v1.Fecha_Salida) > 6 AND YEAR(v1.Fecha_Salida)= " + int.Parse(txtAnio.Text) + @"
                                                        order by CantidadCabinasLibres DESC", c);

                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
        }
    }
}
