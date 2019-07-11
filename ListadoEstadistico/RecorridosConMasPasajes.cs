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
    public partial class RecorridosConMasPasajes : Form
    {
        public RecorridosConMasPasajes()
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxSemestre.SelectedItem == "Primer Semestre")
            {
                var c = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
                SqlCommand comando = new SqlCommand("SELECT TOP 5 r1.Codigo_Recorrido as CodigoRecorrido, r1.IdRecorrido, COUNT(IdPasaje) as CantidadDePasajesComprados, pto.Nombre as PuertoOrigen from LOS_QUE_VAN_A_APROBAR.Pasaje p1 join LOS_QUE_VAN_A_APROBAR.Viaje v1 on (p1.IdViaje = v1.IdViaje) join LOS_QUE_VAN_A_APROBAR.Recorrido r1 on (v1.IdRecorrido = r1.IdRecorrido) join LOS_QUE_VAN_A_APROBAR.RecorridoPorTramo rt1 on (r1.IdRecorrido = rt1.CodigoRecorrido) join LOS_QUE_VAN_A_APROBAR.Tramo t1 on (rt1.CodigoTramo = t1.IdTramo) join LOS_QUE_VAN_A_APROBAR.Puerto pto on (t1.Puerto_Salida = pto.Nombre) where rt1.CodigoTramo in (select MIN(CodigoTramo) from LOS_QUE_VAN_A_APROBAR.RecorridoPorTramo rpt2  where rpt2.CodigoRecorrido = r1.IdRecorrido ) AND MONTH(p1.Fecha_Salida) <= 6 AND YEAR(p1.Fecha_Salida)= " + int.Parse(txtAnio.Text) + @"
                                                        group by r1.Codigo_Recorrido, r1.IdRecorrido, pto.Nombre
                                                        order by CantidadDePasajesComprados DESC", c);

                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;

            }
            else if (comboBoxSemestre.SelectedItem == "Segundo Semestre")
            {
                var c = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
                SqlCommand comando = new SqlCommand("SELECT TOP 5 r1.Codigo_Recorrido as CodigoRecorrido, r1.IdRecorrido, COUNT(IdPasaje) as CantidadDePasajesComprados, pto.Nombre as PuertoOrigen from LOS_QUE_VAN_A_APROBAR.Pasaje p1 join LOS_QUE_VAN_A_APROBAR.Viaje v1 on (p1.IdViaje = v1.IdViaje) join LOS_QUE_VAN_A_APROBAR.Recorrido r1 on (v1.IdRecorrido = r1.IdRecorrido) join LOS_QUE_VAN_A_APROBAR.RecorridoPorTramo rt1 on (r1.IdRecorrido = rt1.CodigoRecorrido) join LOS_QUE_VAN_A_APROBAR.Tramo t1 on (rt1.CodigoTramo = t1.IdTramo) join LOS_QUE_VAN_A_APROBAR.Puerto pto on (t1.Puerto_Salida = pto.Nombre) where rt1.CodigoTramo in (select MIN(CodigoTramo) from LOS_QUE_VAN_A_APROBAR.RecorridoPorTramo rpt2  where rpt2.CodigoRecorrido = r1.IdRecorrido ) AND MONTH(p1.Fecha_Salida) > 6 AND YEAR(p1.Fecha_Salida)= " + int.Parse(txtAnio.Text) + @"
                                                        group by r1.Codigo_Recorrido, r1.IdRecorrido, pto.Nombre
                                                        order by CantidadDePasajesComprados DESC", c);

                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
        }


        private void comboBoxSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAnio_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
