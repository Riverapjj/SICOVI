using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SICOVI.Clases;
using SICOVI.Modelos;
using System.Data.SqlClient;

namespace SICOVI.Data
{
    class UsuariosD
    {
        Conexion conexion;


        public UsuariosD()
        {
            conexion = new Conexion();
        }

        public Usuarios login(string NomUsuario, string Clave)
        {
            Usuarios usuarios = null;

            string comando = "SELECT * FROM Personal WHERE Usuario = @NomUsuario AND Clave = @Clave";
            SqlParameterCollection parametros = new SqlCommand().Parameters;
            parametros.AddWithValue("@NomUsuario", NomUsuario);
            parametros.AddWithValue("@Clave", Clave);
            SqlDataReader dataReader = null;

            dataReader = conexion.retornarLista(comando, parametros);

            while (dataReader.Read())
            {
                usuarios = new Usuarios()
                {
                    Nombre = dataReader["Nombre"].ToString(),
                    Usuario = dataReader["Usuario"].ToString(),
                    Contra = dataReader["Clave"].ToString(),
                    Rango = (int) dataReader["Rango"],
                    Dui = dataReader["DUI"].ToString(),
                    Telefono = dataReader["Telefono"].ToString(),
                    Email = dataReader["Email"].ToString()
                };
            }

            return usuarios;
        }
    }
}
