using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FrbaCrucero
{
    public static class SqlConnection
    {
        private static SqlConnection NewDBConnection(){
            SqlConnection Conexion = new SqlConnection("LAPTOP-KTFT0KNA\SQLSERVER2012 ; GD1C2019 ; true");
            Conexion.Open();
        }
    }
}
