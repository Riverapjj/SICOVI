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
    class RangosD
    {
        Conexion conexion;

        public RangosD()
        {
            conexion = new Conexion();
        }

        public bool insertarRangos(Rangos rango)
        {
            bool resultado = false;
            string comando = "Insertar_rangos";

            SqlParameterCollection parametros = new SqlCommand().Parameters;

            parametros.AddWithValue("@NombreRango", rango.Nombre_rango);

            try
            {
                resultado = conexion.insert(comando, parametros);
            }
            catch
            {
                resultado = false;
            }

            return resultado;
        }

        public List<Rangos> obtenerRangos()
        {
            SqlDataReader dataReader;
            List<Rangos> listaRangos = new List<Rangos>();
            string consulta = "SELECT ID_Rango, Nombre FROM Rango";

            dataReader = conexion.retornarLista(consulta, null);

            while (dataReader.Read())
            {
                listaRangos.Add(new Rangos()
                {
                    Id_Rango = Convert.ToInt32(dataReader["ID_Rango"].ToString()),
                    Nombre_rango = dataReader["Nombre"].ToString()
                });
            }

            conexion.desconectar();

            return listaRangos;
        }

        public Rangos obtenerUnRango(int ID_Rango)
        {

            SqlDataReader dataReader = null;
            Rangos rango = new Rangos();
            string consulta = "SELECT ID_Rango, Nombre FROM Rango WHERE ID_Rango = @ID_Rango";
            SqlParameterCollection parametro = new SqlCommand().Parameters;

            parametro.AddWithValue("@ID_Rango", ID_Rango);
            dataReader = conexion.retornarLista(consulta, parametro);

            while (dataReader.Read())
            {
                rango = new Rangos()
                {
                    Id_Rango = Convert.ToInt32(dataReader["ID_Rango"]),
                    Nombre_rango = dataReader["Nombre"].ToString()
                };
            }

            conexion.desconectar();
            return rango;
        }

        public List<string> obtenerFormularios(int ID_Rango)
        {
            List<string> listaFormularios = new List<string>();
            SqlDataReader dataReader = null;
            string consulta = "SELECT Nombre_BtnFormulario " +
                "FROM Formularios F " +
                "INNER JOIN FormulariosXRango FR ON F.ID_Formulario = FR.ID_Formulario " +
                "WHERE ID_Rango = @ID_Rango";

            SqlParameterCollection parametro = new SqlCommand().Parameters;

            parametro.AddWithValue("@ID_Rango", ID_Rango);
            dataReader = conexion.retornarLista(consulta, parametro);

            while (dataReader.Read())
            {
                listaFormularios.Add(dataReader["Nombre_BtnFormulario"].ToString());
            }

            conexion.desconectar();
            return listaFormularios;
        }
    }
}
