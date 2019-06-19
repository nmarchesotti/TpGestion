using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace FrbaCrucero.LoginYSeguridad
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            //INSTANCIO LA CLASE SQL CONNECTION
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);

            cn.Open();

            MessageBox.Show("Conexion existosa");

            cn.Close();

            /*String conexion = @"Data Source=FELIPE\SQLSERVER2012;Initial Catalog=GD1C2019;User ID=gdCruceros2019;Password=gd2019";
            SqlConnection conn = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand("ValidarAdministrador", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter(txtusuario.Text, txtcontraseña.Text));
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                System.Windows.Forms.MessageBox.Show("Login valido");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Login inválido");
            }*/
        }
    }
}

