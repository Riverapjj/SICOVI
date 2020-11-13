using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SICOVI.Clases;
using SICOVI.Modelos;
using System.Data.SqlClient;

namespace SICOVI.Data
{
    class VacunasD
    {
        Conexion conexion;

        public VacunasD()
        {
            conexion = new Conexion();
        }

        public bool insertarVacuna(Vacunas vacunas)
        {
            bool resultado;
            string comando = "Insertar_Vacuna";
            SqlParameterCollection parametros = new SqlCommand().Parameters;

            parametros.AddWithValue("@Nombre", vacunas.Nombre);
            parametros.AddWithValue("@Descripcion", vacunas.Descripcion);
            parametros.AddWithValue("@Edad_Aplicacion", vacunas.Edad);

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

        public List<Vacunas> obtenerVacunas()
        {
            SqlDataReader dataReader;
            List<Vacunas> listaVacunas = new List<Vacunas>();
            string consulta = "SELECT Nombre, Descripcion, Edad_Aplicacion AS [Edad de aplicacion] FROM Vacunas";

            dataReader = conexion.retornarLista(consulta, null);

            while (dataReader.Read())
            {
                listaVacunas.Add(new Vacunas() {

                    Nombre = dataReader["Nombre"].ToString(),
                    Descripcion = dataReader["Descripcion"].ToString(),
                    Edad = Convert.ToInt32(dataReader["Edad de aplicacion"])
                });
            }

            conexion.desconectar();

            return listaVacunas;
        }



        public Vacunas obtenerUnaVacuna(string NombreVacuna)
        {

            SqlDataReader dataReader = null;
            Vacunas vacunas = new Vacunas();
            string consulta = "SELECT ID_Vacuna, Nombre, Descripcion, Edad_Aplicacion FROM Vacunas WHERE Nombre = @Nombre";
            SqlParameterCollection parametro = new SqlCommand().Parameters;

            parametro.AddWithValue("@Nombre", NombreVacuna);
            dataReader = conexion.retornarLista(consulta, parametro);

            while(dataReader.Read())
            {
                vacunas = new Vacunas()
                {
                    ID_Vacuna = Convert.ToInt32(dataReader["ID_Vacuna"]),
                    Nombre = dataReader["Nombre"].ToString(),
                    Descripcion = dataReader["Descripcion"].ToString(),
                    Edad = Convert.ToInt32(dataReader["Edad_Aplicacion"])
                };
            }

            conexion.desconectar();
            return vacunas;
        }

        public bool actualizarVacunas(Vacunas vacunas)
        {
            bool resultado = false;
            string consulta = "Actualizar_Vacuna";
            SqlParameterCollection parametros = new SqlCommand().Parameters;

            parametros.AddWithValue("@ID_Vacuna", vacunas.ID_Vacuna);
            parametros.AddWithValue("@Nombre", vacunas.Nombre);
            parametros.AddWithValue("@Descripcion", vacunas.Descripcion);
            parametros.AddWithValue("@Edad_Aplicacion", vacunas.Edad);

            try
            {
                resultado = conexion.update(consulta, parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return resultado;
        }
    }
}
