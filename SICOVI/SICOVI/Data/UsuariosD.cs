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

        public bool insertarUsuario(Usuarios usuario)
        {
            bool insertado = false;
            string comando = "Insertar_usuarios";
            SqlParameterCollection parametros = new SqlCommand().Parameters;

            parametros.AddWithValue("@Nombre", usuario.Nombre);
            parametros.AddWithValue("@Usuario", usuario.Usuario);
            parametros.AddWithValue("@Clave", usuario.Contra);
            parametros.AddWithValue("@ID_Rango", usuario.Rango);
            parametros.AddWithValue("@DUI", usuario.Dui);
            parametros.AddWithValue("@Telefono", usuario.Telefono);
            parametros.AddWithValue("@Email", usuario.Email);

            try
            {
                insertado = conexion.insert(comando, parametros);
            }
            catch
            {
                insertado = false;
            }

            return insertado;
        }

        public Usuarios obtenerUnUsuario(int IdUsuario)
        {
            Usuarios usuario = new Usuarios(); ;
            SqlDataReader dataReader;
            string consulta = "SELECT ID_Personal, P.Nombre, Usuario, Clave, Rango, R.Nombre AS NomRango, DUI, Telefono, Email FROM Personal P " +
                "INNER JOIN Rango R " +
                "ON P.Rango = R.ID_Rango " +
                "WHERE ID_Personal = @IdUsuario";
            SqlParameterCollection parametro = new SqlCommand().Parameters;

            parametro.AddWithValue("@IdUsuario", IdUsuario);

            dataReader = conexion.retornarLista(consulta, parametro);

            while (dataReader.Read())
            {
                usuario = new Usuarios() 
                {
                    ID_Usuario = (int)dataReader["ID_Personal"],
                    Nombre = dataReader["Nombre"].ToString(),
                    Usuario = dataReader["Usuario"].ToString(),
                    Contra = dataReader["Clave"].ToString(),
                    Rango = (int)dataReader["Rango"],
                    NomRango = dataReader["NomRango"].ToString(),
                    Dui = dataReader["DUI"].ToString(),
                    Telefono = dataReader["Telefono"].ToString(),
                    Email = dataReader["Email"].ToString()

                };
            }
            return usuario;
        }

        public bool actualizarUsuarios(Usuarios usuarios)
        {
            bool resultado = false;
            string consulta = "Actualizar_usuario";
            SqlParameterCollection parametros = new SqlCommand().Parameters;

            parametros.AddWithValue("ID_Personal", usuarios.ID_Usuario);
            parametros.AddWithValue("Nombre", usuarios.Nombre);
            parametros.AddWithValue("Usuario", usuarios.Usuario);
            parametros.AddWithValue("Clave", usuarios.Contra);
            parametros.AddWithValue("ID_Rango", usuarios.Rango);
            parametros.AddWithValue("DUI", usuarios.Dui);
            parametros.AddWithValue("Telefono", usuarios.Telefono);
            parametros.AddWithValue("Email", usuarios.Email);

            try
            {
                resultado = conexion.update(consulta, parametros);
            }
            catch 
            {
                resultado = false;  
            }

            return resultado;


        }

        public List<Usuarios> obtenerUsuarios()
        {
            List<Usuarios> listaUsuarios = new List<Usuarios>();
            SqlDataReader dataReader;
            string consulta = "SELECT ID_Personal, P.Nombre, Usuario, Clave, Rango, R.Nombre AS NomRango, DUI, Telefono, Email FROM Personal P " +
                "INNER JOIN Rango R " +
                "ON P.Rango = R.ID_Rango";

            dataReader = conexion.retornarLista(consulta, null);

            while (dataReader.Read())
            { 
                listaUsuarios.Add(new Usuarios { 
                
                    ID_Usuario = (int) dataReader["ID_Personal"],
                    Nombre = dataReader["Nombre"].ToString(),
                    Usuario = dataReader["Usuario"].ToString(),
                    Contra = dataReader["Clave"].ToString(),
                    Rango = (int)dataReader["Rango"],
                    NomRango = dataReader["NomRango"].ToString(),
                    Dui = dataReader["DUI"].ToString(),
                    Telefono = dataReader["Telefono"].ToString(),
                    Email = dataReader["Email"].ToString()
                });
            }

            return listaUsuarios;
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
