using AutomatizacionDePruebas.Servicio;
using AutomatizacionDePruebas.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizacionDePruebasTest
{
    public class ServicioPersonaTest
    {
        private ServicioPersona _servicio;

        [SetUp]
        public void Setup()
        {
            _servicio = new ServicioPersona();
        }

        [Test]
        public void Test_PersonaConNombreVacioEsInvalido()
        {
            var persona = new Persona() { Nombre = String.Empty };
            var resultado = _servicio.EsValido(persona);
            Assert.IsFalse(resultado);
            Assert.IsTrue(_servicio.Errores.Any());
        }
        [Test]
        public void Test_PersonaConEdadNegativa()
        {
            var persona = new Persona() { Nombre = "Pepe", Edad = -3 };
            var resultado = _servicio.EsValido(persona);
            Assert.IsFalse(resultado);
            Assert.IsTrue(_servicio.Errores.Any());
        }
        [Test]
        public void Test_PersonaConEdadMuyAlta()
        {
            var persona = new Persona() { Nombre = "Pepe", Edad = 201 };
            var resultado = _servicio.EsValido(persona);
            Assert.IsFalse(resultado);
            Assert.IsTrue(_servicio.Errores.Any());
        }
        [Test]
        public void Test_PersonaConValoresQueLanzaExcepcion()
        {
            var persona = new Persona() { Nombre = "Jose", Edad = 45 };
            var ex = Assert.Throws<ApplicationException>(() => _servicio.EsValido(persona));
            Assert.That(ex.Message, Is.EqualTo("¡¡¡El nombre Jose es un nombre prohibido!!!"));
        }
        [TestCase(31, 32)]
        [TestCase(100, 101)]
        [TestCase(-40, -39)]
        public void Test_SumarUnoEdad_VariosSeguidos(int edad, int edadEsperada)
        {
            var resultado = _servicio.SumarUno(edad);
            Assert.That(resultado, Is.EqualTo(edadEsperada));
        }
    }
}
