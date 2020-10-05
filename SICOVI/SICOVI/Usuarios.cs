using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICOVI
{
    class Usuarios
    {
        string nombre;
        string usuario;
        string contra;
        string rango;
        string dui;
        string telefono;
        string email;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contra { get => contra; set => contra = value; }
        public string Dui { get => dui; set => dui = value; }
        public string Rango { get => rango; set => rango = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
    }
}
