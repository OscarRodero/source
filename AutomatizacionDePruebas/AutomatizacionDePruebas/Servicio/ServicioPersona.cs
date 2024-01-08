using AutomatizacionDePruebas.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizacionDePruebas.Servicio
{
    public class ServicioPersona
    {
        public List<string> Errores { get; set; }
        public ServicioPersona()
        {
            Errores = new List<string>();
        }
        public bool EsValido(Persona persona)
        {
            Errores = new List<string>();
            var valido = false;
            if (string.IsNullOrWhiteSpace(persona.Nombre))
            {
                Errores.Add("El nombre de la persona es un valor requerido");
                valido = false;
            }
            if (persona.Edad > 200)
            {
                valido = false;
                Errores.Add("La edad de la persona no puede ser mayor de 200");
            }
            if (persona.Edad < 0)
            {
                valido = false;
                Errores.Add("La edad de la persona no puede ser negativa");
            }
            if (persona.Nombre.Equals("Jose"))
            {
                throw new ApplicationException("¡¡¡El nombre Jose es un nombre prohibido!!!");
            }
            return valido;
        }
        public int SumarUno(int edadOriginal)
        {
            return edadOriginal + 1;
        }
    }
}
