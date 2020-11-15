using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICOVI.Modelos
{
    public class Usuarios
    {
        int id_usuario;
        string nombre;
        string usuario;
        string contra;
        int rango;
        string nomrango;
        string dui;
        string telefono;
        string email;

        public int ID_Usuario { get => id_usuario; set => id_usuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contra { get => contra; set => contra = value; }
        public string Dui { get => dui; set => dui = value; }
        public int Rango { get => rango; set => rango = value; }
        public string NomRango { get => nomrango; set => nomrango = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
    }
}
