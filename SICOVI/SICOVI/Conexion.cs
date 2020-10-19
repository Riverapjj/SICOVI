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
        public void abrirConexion()
        {
            string connString = devolverString();

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connString;

                connection.Open();

                Console.WriteLine("State: {0}", connection.State);
                Console.WriteLine("ConnectionString: {0}",
                    connection.ConnectionString);
            }
        }

        static private string devolverString()
        {
            // To avoid storing the connection string in your code,
            // you can retrieve it from a configuration file.
            return "Data Source=LAPTOP\\LAPTOP;Initial Catalog=SICOVI;"
                + "Integrated Security=true;";
        }
    }
}
