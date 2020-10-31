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
    class PacientesD
    {
        Conexion conexion;

        public PacientesD()
        {
            conexion = new Conexion();
        }

        public List<Paciente> obtenerPacientes()
        {
            SqlDataReader dataReader;
            List<Paciente> listaPacientes = new List<Paciente>();
            string consulta = "SELECT ID_Paciente, Nombre, Fecha_Nacimiento, Responsable, DUI_Responsable, N_Seguro_Social FROM Pacientes";

            dataReader = conexion.retornarLista(consulta, null);

            while (dataReader.Read())
            {
                listaPacientes.Add(new Paciente()
                {
                    ID_Paciente = dataReader["ID_Paciente"].ToString(),
                    Nombre_paciente = dataReader["Nombre"].ToString(),
                    Fecha_nacimiento = Convert.ToDateTime(dataReader["Fecha_Nacimiento"]),
                    Nombre_responsable = dataReader["Responsable"].ToString(),
                    Num_dui_resposable = dataReader["DUI_Responsable"].ToString(),
                    Num_seguro_responsable = dataReader["N_Seguro_Social"].ToString()
                });
            }

            conexion.desconectar();

            return listaPacientes;
        }

        public bool actualizarPaciente(Paciente paciente)
        {
            bool resultado = false;
            string consulta = "Actualizar_Paciente";
            SqlParameterCollection parametros = new SqlCommand().Parameters;

            parametros.AddWithValue("@ID_Paciente", paciente.ID_Paciente);
            parametros.AddWithValue("@Nombre", paciente.Nombre_paciente);
            parametros.AddWithValue("@Fecha_Nacimiento", paciente.Fecha_nacimiento);
            parametros.AddWithValue("@Madre", paciente.Nombre_madre);
            parametros.AddWithValue("@Padre", paciente.Nombre_padre);
            parametros.AddWithValue("@Responsable", paciente.Nombre_responsable);
            parametros.AddWithValue("@DUI_Responsable", paciente.Num_dui_resposable);
            parametros.AddWithValue("@N_Seguro_Social", paciente.Num_seguro_responsable);

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

        public Paciente obtenerUnPaciente(string IDPaciente)
        {

            SqlDataReader dataReader = null;
            Paciente paciente = new Paciente();
            string consulta = "SELECT * FROM Pacientes WHERE ID_Paciente = @ID_Paciente";
            SqlParameterCollection parametro = new SqlCommand().Parameters;

            parametro.AddWithValue("@ID_Paciente", IDPaciente);
            dataReader = conexion.retornarLista(consulta, parametro);

            while (dataReader.Read())
            {
                paciente = new Paciente()
                {
                    ID_Paciente = dataReader["ID_Paciente"].ToString(),
                    Nombre_paciente = dataReader["Nombre"].ToString(),
                    Fecha_nacimiento = Convert.ToDateTime(dataReader["Fecha_Nacimiento"]),
                    Nombre_madre = dataReader["Madre"].ToString(),
                    Nombre_padre = dataReader["Padre"].ToString(),
                    Nombre_responsable = dataReader["Responsable"].ToString(),
                    Num_dui_resposable = dataReader["DUI_Responsable"].ToString(),
                    Num_seguro_responsable = dataReader["N_Seguro_Social"].ToString()
                };
            }

            conexion.desconectar();
            return paciente;
        }

        public bool insertarPacientes(Paciente paciente)
        {
            bool resultado = false;
            string comando = "Insertar_Paciente";

            SqlParameterCollection parametros = new SqlCommand().Parameters;

            parametros.AddWithValue("@Nombre", paciente.Nombre_paciente);
            parametros.AddWithValue("@Fecha_Nacimiento", paciente.Fecha_nacimiento);
            parametros.AddWithValue("@Madre", paciente.Nombre_madre);
            parametros.AddWithValue("@Padre", paciente.Nombre_padre);
            parametros.AddWithValue("@Responsable", paciente.Nombre_responsable);
            parametros.AddWithValue("@DUI_Responsable", paciente.Num_dui_resposable);
            parametros.AddWithValue("@N_Seguro_Social", paciente.Num_seguro_responsable);

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
