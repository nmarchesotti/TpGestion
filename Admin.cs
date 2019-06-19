using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration

namespace FrbaCrucero
{
    class Admin:IAdmin
         
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public int IdRol { get; set; }
    }

    public Admin (){}

    public Admin( string _nombre, string _contrasena, int _idRol){
    
    this.Nombre=nombre;
    this.Contrasena=contrasena;
    this.IdRol=idRol;

    }

}
