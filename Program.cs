﻿using System;
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
            
            
           LoginYSeguridad.Login var = new LoginYSeguridad.Login();
            var.Show();
            Application.Run();  // Para probar varios forms en una sola ejecucion

            /*AbmPuerto.ABMPuerto var1 = new AbmPuerto.ABMPuerto();
            var1.Show();
            Application.Run();*/

            //Application.Run(new AbmRol.AltaRol());  // Para probar un solo FORM

        }
    }
}
