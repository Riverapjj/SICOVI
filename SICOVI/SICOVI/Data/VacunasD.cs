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

            parametros.Add("@Nombre", vacunas.Nombre_vacuna);
            parametros.Add("@Descripcion", vacunas.Descripción_vacuna);
            parametros.Add("@Edad_Aplicacion", vacunas.Edad_aplicacion);

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
    }
}
