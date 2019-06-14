using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.LoginYSeguridad
{
    List<string> res = new List<string>();
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
            if (Validacion(txtusuario.Text, txtcontraseña.Text))
            {
                menuAdmin menu = new menuAdmin();
                menu.Show();
                this.Dispose();
            }
            else { 
           tirarError()
            }
        }
    }
}

static public tipoDato EjecutarSP(string sp, SqlParameter[] parametros)
    {
        try
        {
            SqlCommand command = new SqlCommand(sp, ConexionBD.con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(parametros);
            ConexionBD.Conectar();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
            string aux = reader.GetString(0) 
            res.Add(aux);   
            }
            ConexionBD.Desconectar();
            return resultado;
        }
        catch (Exception ex)
        {
            throw new Exception(" Error al ejecutar procedimiento almacenado ", ex);
        }
    }