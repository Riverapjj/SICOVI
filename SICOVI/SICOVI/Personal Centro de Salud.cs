using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICOVI
{
    class Personal_Centro_de_Salud
    {
        string nombre_personal;
        string nombre;
        string usuario;
        string contraseña;
        string rango;
        int dui;
        int telefono;
        string email;

        public string Nombre_personal { get => nombre_personal; set => nombre_personal = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Rango { get => rango; set => rango = value; }
        public int Dui { get => dui; set => dui = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
    }
}
