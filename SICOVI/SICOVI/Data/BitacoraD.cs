using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SICOVI.Clases;
using SICOVI.Modelos;

namespace SICOVI.Data
{
    class BitacoraD
    {
        Conexion conexion;

        public BitacoraD()
        {
            conexion = new Conexion();
        }

        public bool insertarBitacora(string NomVacuna, string NomUsuario, string NomPaciente, string Observaciones)
        {
            bool resultado = false;
            string comando = "Insertar_Bitacora";

            SqlParameterCollection parametros = new SqlCommand().Parameters;

            parametros.AddWithValue("@NomVacuna", NomVacuna);
            parametros.AddWithValue("@NomUsuario", NomUsuario);
            parametros.AddWithValue("@NomPaciente", NomPaciente);
            parametros.AddWithValue("@Observaciones", Observaciones);

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

        public List<Bitacora> obtenerBitacora()
        {
            SqlDataReader dataReader;
            List<Bitacora> listaBitacora = new List<Bitacora>();
            string consulta = "SELECT C.ID_Paciente, V.ID_Vacuna, ID_Doctor, P.Nombre AS NomPaciente, V.Nombre AS NomVacuna, PE.Nombre AS NomUsuario, FechaAplicacion, Observaciones " +
                "FROM Consultas C " +
                "INNER JOIN Pacientes P " +
                "ON C.ID_Paciente = P.ID_Paciente " +
                "INNER JOIN Vacunas V " +
                "ON C.ID_Vacuna = V.ID_Vacuna " +
                "INNER JOIN Personal PE " +
                "ON C.ID_Doctor = PE.ID_Personal";

            dataReader = conexion.retornarLista(consulta, null);

            while (dataReader.Read())
            {
                listaBitacora.Add(new Bitacora()
                {
                    ID_Paciente = dataReader["ID_Paciente"].ToString(),
                    ID_Vacuna = (int) dataReader["ID_Vacuna"],
                    ID_Usuario = (int) dataReader["ID_Doctor"],
                    NomPaciente = dataReader["NomPaciente"].ToString(),
                    NomVacuna = dataReader["NomVacuna"].ToString(),
                    NomUsuario = dataReader["NomUsuario"].ToString(),
                    FechaAplicacion = (DateTime) dataReader["FechaAplicacion"],
                    Observaciones = dataReader["Observaciones"].ToString()
                });
            }

            conexion.desconectar();

            return listaBitacora;
        }

        public List<string> llenarCmbPacientes()
        {
            List<string> listaDePacientes = new List<string>();
            SqlDataReader dataReader;

            string comando = "SELECT Nombre FROM Pacientes";

            dataReader = conexion.retornarLista(comando, null);
            

            while (dataReader.Read())
            {
                listaDePacientes.Add("Todos");
                listaDePacientes.Add(dataReader["Nombre"].ToString());
            }


            return listaDePacientes;
        }

        public List<Bitacora> obtenerBitacoraXPaciente(string NomPaciente)
        {
            SqlDataReader dataReader;
            List<Bitacora> listaBitacora = new List<Bitacora>();
            SqlParameterCollection parametro = new SqlCommand().Parameters;
            string consulta = "SELECT C.ID_Paciente, V.ID_Vacuna, ID_Doctor, P.Nombre AS NomPaciente, V.Nombre AS NomVacuna, PE.Nombre AS NomUsuario, FechaAplicacion, Observaciones " +
                "FROM Consultas C " +
                "INNER JOIN Pacientes P " +
                "ON C.ID_Paciente = P.ID_Paciente " +
                "INNER JOIN Vacunas V " +
                "ON C.ID_Vacuna = V.ID_Vacuna " +
                "INNER JOIN Personal PE " +
                "ON C.ID_Doctor = PE.ID_Personal" +
                " WHERE P.Nombre = @NomPaciente";

            parametro.AddWithValue("@NomPaciente", NomPaciente);

            dataReader = conexion.retornarLista(consulta, parametro);

            while (dataReader.Read())
            {
                listaBitacora.Add(new Bitacora()
                {
                    ID_Paciente = dataReader["ID_Paciente"].ToString(),
                    ID_Vacuna = (int)dataReader["ID_Vacuna"],
                    ID_Usuario = (int)dataReader["ID_Doctor"],
                    NomPaciente = dataReader["NomPaciente"].ToString(),
                    NomVacuna = dataReader["NomVacuna"].ToString(),
                    NomUsuario = dataReader["NomUsuario"].ToString(),
                    FechaAplicacion = (DateTime)dataReader["FechaAplicacion"],
                    Observaciones = dataReader["Observaciones"].ToString()
                });
            }

            conexion.desconectar();

            return listaBitacora;
        }

    }
}
