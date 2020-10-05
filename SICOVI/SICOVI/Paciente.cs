using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICOVI
{
    class Paciente
    {
        string nombre_paciente;
        DateTime fecha_nacimiento;
        string nombre_madre;
        string nombre_padre;
        bool nombre_responsable;
        string num_dui_resposable;
        string num_seguro_responsable;

        public string Nombre_paciente { get => nombre_paciente; set => nombre_paciente = value; }
        public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public string Nombre_madre { get => nombre_madre; set => nombre_madre = value; }
        public string Nombre_padre { get => nombre_padre; set => nombre_padre = value; }
        public string Nombre_responsable { get => nombre_responsable; set => nombre_responsable = value; }
        public string Num_dui_resposable { get => num_dui_resposable; set => num_dui_resposable = value; }
        public string Num_seguro_responsable { get => num_seguro_responsable; set => num_seguro_responsable = value; }
    }
}
