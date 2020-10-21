using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICOVI.Modelos
{
    public class Vacunas
    {

        string nombre_vacuna;
        string descripción_vacuna;
        int edad_aplicacion;


        
        public string Nombre_vacuna { get => nombre_vacuna; set => nombre_vacuna = value; }
        public string Descripción_vacuna { get => descripción_vacuna; set => descripción_vacuna = value; }
        public int Edad_aplicacion { get => edad_aplicacion; set => edad_aplicacion = value; }
    }
}
