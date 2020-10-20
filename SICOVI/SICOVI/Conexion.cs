using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICOVI
{
    public class Conexion
    {
        public string servidor, cadena;

        public void conectar()
        {
            servidor = "LAPTOP\\LAPTOP";

            cadena = "Data Source=" + servidor +";Initial Catalog=SICOVI;"
                + "Integrated Security=true;";
        }
    }
}
