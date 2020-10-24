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

            parametros.Add("@Nombre", vacunas.Nombre);
            parametros.Add("@Descripcion", vacunas.Descripcion);
            parametros.Add("@Edad_Aplicacion", vacunas.Edad);

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
    }
}
