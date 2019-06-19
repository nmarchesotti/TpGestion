using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero
{
    interface IAdmin
    {
        bool Validar();

        bool Crear();

        DataTable Listar();
    }
}
