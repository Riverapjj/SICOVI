using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICOVI.Modelos
{
    class Bitacora
    {
        string id_paciente;
        int id_vacuna;
        int id_usuario;
        string nompaciente;
        string nomvacuna;
        string nomusuario;
        DateTime fechaaplicacion;
        string observaciones;

        public string ID_Paciente { get => id_paciente; set => id_paciente = value; }
        public int ID_Vacuna { get => id_vacuna; set => id_vacuna = value; }
        public int ID_Usuario { get => id_usuario; set => id_usuario = value; }
        public string NomPaciente { get => nompaciente; set => nompaciente = value; }
        public string NomVacuna { get => nomvacuna; set => nomvacuna = value; }
        public string NomUsuario { get => nomusuario; set => nomusuario = value; }
        public DateTime FechaAplicacion { get => fechaaplicacion; set => fechaaplicacion = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }

    }
}
