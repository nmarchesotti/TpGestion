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
    public partial class CrucerosConMasFueraDeServicio : Form
    {
        public CrucerosConMasFueraDeServicio()
        {
            InitializeComponent();
            inicializarSemestre();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListadoEstadistico.MenuListadoEstadistico form = new MenuListadoEstadistico();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Dispose();
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




        private void comboBoxSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxSemestre.SelectedItem == "Primer Semestre")
            {
                var c = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
                SqlCommand comando = new SqlCommand("select TOP 5 c1.IdCrucero, m1.Descripcion as Marca, m2.Descripcion as Modelo, sum(LOS_QUE_VAN_A_APROBAR.diasFuera(" + int.Parse(txtAnio.Text) + @",1,f1.FechaBaja, f1.FechaReinicio)) as CantidadDiasFueraDeServicio
                            from LOS_QUE_VAN_A_APROBAR.FueraDeServicio f1 join LOS_QUE_VAN_A_APROBAR.Crucero c1 on (f1.IdCrucero = c1.IdCrucero) join LOS_QUE_VAN_A_APROBAR.Marca m1 on (c1.IdMarca = m1.IdMarca) join LOS_QUE_VAN_A_APROBAR.Modelo m2 on (c1.IdModelo = m2.IdModelo)
                            group by c1.IdCrucero, m1.Descripcion, m2.Descripcion 
                            order by CantidadDiasFueraDeServicio DESC", c);
                
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;

            }
            else if(comboBoxSemestre.SelectedItem == "Segundo Semestre")
            {
                var c = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
                SqlCommand comando = new SqlCommand("select TOP 5 c1.IdCrucero, m1.Descripcion as Marca, m2.Descripcion as Modelo, sum(LOS_QUE_VAN_A_APROBAR.diasFuera(" + int.Parse(txtAnio.Text) + @",2,f1.FechaBaja, f1.FechaReinicio)) as CantidadDiasFueraDeServicio
                            from LOS_QUE_VAN_A_APROBAR.FueraDeServicio f1 join LOS_QUE_VAN_A_APROBAR.Crucero c1 on (f1.IdCrucero = c1.IdCrucero) join LOS_QUE_VAN_A_APROBAR.Marca m1 on (c1.IdMarca = m1.IdMarca) join LOS_QUE_VAN_A_APROBAR.Modelo m2 on (c1.IdModelo = m2.IdModelo)
                            group by c1.IdCrucero, m1.Descripcion, m2.Descripcion 
                            order by CantidadDiasFueraDeServicio DESC", c);
                
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
           
        }

        private void txtAnio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
