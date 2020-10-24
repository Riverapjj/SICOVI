using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace SICOVI.Clases
{
    public class Conexion
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        public Conexion()
        {
            string servidor, cadena;
            servidor = "LAPTOP\\LAPTOP";

            cadena = "Data Source=" + servidor + ";Initial Catalog=SICOVI;"
                + "Integrated Security=true;";

            conn = new SqlConnection(cadena);
        }

        public void conectar()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn.Open();
            }
            else 
            {
                conn.Open();
            }
        }

        public void desconectar()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public bool insert(string comando, SqlParameterCollection parametros)
        {
            bool insertado = false;

            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = comando;
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (SqlParameter param in parametros)
                {
                    cmd.Parameters.AddWithValue(param.ParameterName, param.Value);
                }

                conectar();
                cmd.ExecuteNonQuery();
                desconectar();
                insertado = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return insertado;
        }

        public SqlDataReader retornarLista(string consulta, SqlParameterCollection parametros)
        {
            cmd = new SqlCommand(consulta, conn);
            conectar();
            if (parametros != null)
            {
                foreach (SqlParameter param in parametros)
                {
                    cmd.Parameters.AddWithValue(param.ParameterName, param.Value);
                }
            }

            SqlDataReader dataReader = cmd.ExecuteReader();

            return dataReader;
        }

        public bool update(string comando, SqlParameterCollection parametros)
        {
            bool actualizado = false;
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = comando;
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (SqlParameter param in parametros)
                {
                    cmd.Parameters.AddWithValue(param.ParameterName, param.Value);
                }
                conectar();
                cmd.ExecuteNonQuery();
                actualizado = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            desconectar();
            return actualizado;
        }

    }

        

        
}
