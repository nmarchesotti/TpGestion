using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            
            /*AbmCrucero.ABMCrucero var = new AbmCrucero.ABMCrucero();
            var.Show();
            Application.Run();*/  // Para probar varios forms en una sola ejecucion


            Application.Run(new AbmCrucero.ListaCruceros());  // Para probar un solo FORM

        }
    }
}
