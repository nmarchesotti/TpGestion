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
            lista.Columns.Add("IdCrucero", -2, HorizontalAlignment.Center);
            lista.Columns.Add("Marca", -2, HorizontalAlignment.Center);
            lista.Columns.Add("Modelo", -2, HorizontalAlignment.Center);
            lista.Columns.Add("Cantidad de cabinas", -2, HorizontalAlignment.Center);

            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
            cn.Open();

            SqlCommand sc = new SqlCommand("select IdModelo, Descripcion from LOS_QUE_VAN_A_APROBAR.Modelo", cn);
            SqlDataReader dr = sc.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lstItem = new ListViewItem();
                lista.SubItems.Add(dr["IdCrucero"].ToString());
                lista.SubItems.Add(dr["Marca"].ToString());
                lista.SubItems.Add(dr["Modelo"].ToString());
                lista.SubItems.Add(dr["CantidadCabinas"].ToString());
                lista.SubItems.Add(lstItem);

            }
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
