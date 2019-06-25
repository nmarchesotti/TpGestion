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

namespace FrbaCrucero.LoginYSeguridad
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("select LOS_QUE_VAN_A_APROBAR.ValidarAdministrador(@Username,@Password)", cn))
                {
                    cn.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@Username", SqlDbType.NVarChar, 100).Value = txtusuario.Text;
                    cmd.Parameters.Add("@Password", SqlDbType.NVarChar, 255).Value = txtcontraseña.Text;
                    int resultado = Convert.ToInt32(cmd.ExecuteScalar());

                    if (resultado == 1)
                    {
                        MessageBox.Show("Conexion exitosa");
                        menuAdmin form = new menuAdmin();
                        form.Show();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Credenciales inválidas");

                    }

                    cn.Close();
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PantallaInicial.Inicio form = new PantallaInicial.Inicio();
            form.Show();
            this.Dispose();
        }
    }
}

