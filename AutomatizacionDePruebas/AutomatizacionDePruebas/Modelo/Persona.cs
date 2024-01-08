using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizacionDePruebas.Modelo
{
    public class Persona
    {
        private int edad;
        private string? nombre;

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }


        public string Nombre
        {
            get { return (nombre == null) ? "" : nombre; }
            set { nombre = value; }
        }

    }
}
