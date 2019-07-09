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

namespace FrbaCrucero
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            /*string[] lines = System.IO.File.ReadAllLines(@"AppConfig.txt");
            string conexion = lines[0];
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings.Remove("GD_CRUCEROS");
            config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings("GD_CRUCEROS", conexion));
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");

            DateTime fechaServidor = Convert.ToDateTime(lines[1]);


            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);

            using (SqlCommand cmd = new SqlCommand("LOS_QUE_VAN_A_APROBAR.ActualizarFecha", cn))
            {
                cn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Fecha", SqlDbType.DateTime2, 3).Value = fechaServidor;
                cmd.ExecuteNonQuery();
            }
            cn.Close();
            cn.Dispose();*/


             SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);

            using (SqlCommand cmd = new SqlCommand("LOS_QUE_VAN_A_APROBAR.ActualizarFecha", cn))
            {
                cn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                string fecha = DateTime.Parse(ConfigurationManager.AppSettings["fecha"]).ToString("yyyy-MM-dd HH:mm:ss");
                cmd.Parameters.Add("@Fecha", SqlDbType.DateTime2, 3).Value = fecha;
                cmd.ExecuteNonQuery();
            }
            cn.Close();
            cn.Dispose();
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /*SqlConnection cn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);

            using (SqlCommand cmd = new SqlCommand("select LOS_QUE_VAN_A_APROBAR.PuertosExtremos(@IdReco)", cn1))
            {
                cn1.Open();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@IdReco", SqlDbType.Int).Value = 89;
                string resultado;
                resultado = Convert.ToString(cmd.ExecuteScalar());
                MessageBox.Show(resultado);
            }
            cn.Close();
            cn.Dispose();*/


            PantallaInicial.Inicio form = new PantallaInicial.Inicio();
            
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            Application.Run();
            
            
            
            
            // Para probar varios forms en una sola ejecucion

            /*AbmPuerto.ABMPuerto var1 = new AbmPuerto.ABMPuerto();
            var1.Show();
            Application.Run();*/

            //Application.Run(new AbmRol.AltaRol());  // Para probar un solo FORM

        }
    }
}
