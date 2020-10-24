using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICOVI.Modelos
{
    public class Vacunas
    {

        string nombre;
        string descripcion;
        int edad;


        
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
