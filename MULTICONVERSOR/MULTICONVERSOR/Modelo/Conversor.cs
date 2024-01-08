using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MULTICONVERSOR.Modelo
{
    public class Conversor
    {
        public List<string> Errores { get; set; }
        public Conversor()
        {
            Errores = new List<string>();
        }
        public float celsiusFarenheit(float celsius)
        {
            var farenheit = (celsius * 1.8f) + 32f;
            return farenheit;
        }
        public float farenheitCelsius(float farenheit)
        {
            var celsius = (farenheit / 1.8f) - 32f;
            return celsius;
        }
        public float pasosKilometros(float pasos) 
        {
            var kilometros = pasos * 0.000305f;
            return kilometros;
        }
        public float kilometrosPasos(float kilometros)
        {
            var pasos = kilometros * 3280.84f;
            return kilometros;
        }
        public float millasKilometros(float millas)
        {
            var kilometros = millas * 1.609344f;
            return kilometros;
        }

        public float kilometrosMillas(float kilometros)
        {
            var millas = kilometros * 0.6213712f;
            return kilometros;
        }     
        public float pasosMillas(float pasos) 
        {
            var millas = pasos * 0.0001893939f;
            return millas;
        }
        public float millasPasos(float millas)
        {
            var pasos = millas * 5280f;
            return pasos;
        }
    }
}
