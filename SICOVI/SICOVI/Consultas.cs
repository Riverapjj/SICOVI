using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICOVI
{
    class Consultas
    {
        string id_consultas;
        string id_vacuna;
        string id_Doctor;
        DateTime fecha_de_Aplicacion;
        string observaciones;

        public string Id_consultas { get => id_consultas; set => id_consultas = value; }
        public string Id_vacuna { get => id_vacuna; set => id_vacuna = value; }
        public string Id_Doctor { get => id_Doctor; set => id_Doctor = value; }
        public DateTime Fecha_de_Aplicacion { get => fecha_de_Aplicacion; set => fecha_de_Aplicacion = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
    }
}
