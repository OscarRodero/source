using PruebasUnitarias;
using System.Windows.Forms;

namespace Pruebas
{
    public class Tests
    {
        private Form1 formulario;
        [SetUp]
        public void Setup()
        {
            formulario = new Form1();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void CelsiusAFarenheit_ConversionCorrecta() 
        {
            formulario.txtCelsius.Text = "0";
            double resultadoEsperado = 32;

            formulario.btnConvertirTemperatura_Click(null, null);

            Assert.AreEqual(resultadoEsperado, double.Parse(formulario.txtFarenheit.Text));
        }
        [Test]
        public void CelsiusAFarenheit_EntradaInvalida()
        {
            formulario.txtCelsius.Text = "no es un número";

            formulario.btnConvertirTemperatura_Click(null, null);

            Assert.IsTrue(string.IsNullOrEmpty(formulario.txtFarenheit.Text));
        }

        [Test]
        public void CelsiusNegativoAFarenheit_NoSeRealizaConversion()
        {
            formulario.txtCelsius.Text = "-10";

            formulario.btnConvertirTemperatura_Click(null, null);

            Assert.IsTrue(string.IsNullOrEmpty(formulario.txtFarenheit.Text));
        }

        [Test]
        public void FarenheitACelsius_ConversionCorrecta()
        {
            formulario.txtFarenheit.Text = "32";
            formulario.txtCelsius.Text = "";
            double resultadoEsperado = 0;

            formulario.btnConvertirTemperatura_Click(null, null);

            Assert.AreEqual(resultadoEsperado, double.Parse(formulario.txtCelsius.Text));
        }

        [Test]
        public void FarenheitACelsius_EntradaInvalida()
        {
            formulario.txtFarenheit.Text = "no es un número";
            formulario.txtCelsius.Text = "";

            formulario.btnConvertirTemperatura_Click(null, null);

            Assert.IsTrue(string.IsNullOrEmpty(formulario.txtCelsius.Text));
        }

        [Test]
        public void FarenheitNegativoACelsius_NoSeRealizaConversion()
        {
            formulario.txtFarenheit.Text = "-10";

            formulario.btnConvertirTemperatura_Click(null, null);

            Assert.IsTrue(string.IsNullOrEmpty(formulario.txtCelsius.Text));
        }

        [Test]
        public void PasosAMillasYKilometros_ConversionCorrecta()
        {
            formulario.txtPasos.Text = "1000";
            double millasEsperadas = 0.473484848;
            double kilometrosEsperados = 0.762;

            formulario.btnConvertirDistancia_Click(null, null);

            Assert.AreEqual(millasEsperadas, double.Parse(formulario.txtMillas.Text));
            Assert.AreEqual(kilometrosEsperados, double.Parse(formulario.txtKilometros.Text));
        }

        [Test]
        public void PasosAMillasYKilometros_EntradaInvalida()
        {
            formulario.txtPasos.Text = "no es un número";

            formulario.btnConvertirDistancia_Click(null, null);

            Assert.IsTrue(string.IsNullOrEmpty(formulario.txtMillas.Text));
            Assert.IsTrue(string.IsNullOrEmpty(formulario.txtKilometros.Text));
        }

        [Test]
        public void PasosAMillasYKilometros_NoSeRealizaConversion()
        {
            formulario.txtPasos.Text = "-10";

            formulario.btnConvertirTemperatura_Click(null, null);

            Assert.IsTrue(string.IsNullOrEmpty(formulario.txtKilometros.Text));
            Assert.IsTrue(string.IsNullOrEmpty(formulario.txtMillas.Text));
        }

        [Test]
        public void MillasAPasosYKilometros_ConversionCorrecta()
        {
            formulario.txtMillas.Text = "1";
            double pasosEsperados = 2112;
            double kilometrosEsperados = 1.60934;

            formulario.btnConvertirDistancia_Click(null, null);

            Assert.AreEqual(pasosEsperados, double.Parse(formulario.txtPasos.Text));
            Assert.AreEqual(kilometrosEsperados, double.Parse(formulario.txtKilometros.Text));
        }

        [Test]
        public void MillasAPasosYKilometros_EntradaInvalida()
        {
            formulario.txtMillas.Text = "no es un número";

            formulario.btnConvertirDistancia_Click(null, null);

            Assert.IsTrue(string.IsNullOrEmpty(formulario.txtPasos.Text));
            Assert.IsTrue(string.IsNullOrEmpty(formulario.txtKilometros.Text));
        }

        [Test]
        public void MillasAPasosYKilometros_NoSeRealizaConversion()
        {
            formulario.txtMillas.Text = "-10";

            formulario.btnConvertirTemperatura_Click(null, null);

            Assert.IsTrue(string.IsNullOrEmpty(formulario.txtKilometros.Text));
            Assert.IsTrue(string.IsNullOrEmpty(formulario.txtPasos.Text));
        }

        [Test]
        public void KilometrosAMillasYPasos_ConversionCorrecta()
        {
            formulario.txtKilometros.Text = "1";
            double millasEsperadas = 0.621371;
            double pasosEsperados = 1312.34;

            formulario.btnConvertirDistancia_Click(null, null);

            Assert.AreEqual(millasEsperadas, double.Parse(formulario.txtMillas.Text));
            Assert.AreEqual(pasosEsperados, double.Parse(formulario.txtPasos.Text));
        }

        [Test]
        public void KilometrosAMillasYPasos_EntradaInvalida()
        {
            formulario.txtKilometros.Text = "no es un número";

            formulario.btnConvertirDistancia_Click(null, null);

            Assert.IsTrue(string.IsNullOrEmpty(formulario.txtMillas.Text));
            Assert.IsTrue(string.IsNullOrEmpty(formulario.txtPasos.Text));
        }

        [Test]
        public void KilometrosAMillasYPasos_NoSeRealizaConversion()
        {
            formulario.txtKilometros.Text = "-10";

            formulario.btnConvertirTemperatura_Click(null, null);

            Assert.IsTrue(string.IsNullOrEmpty(formulario.txtMillas.Text));
            Assert.IsTrue(string.IsNullOrEmpty(formulario.txtPasos.Text));
        }

        [Test]
        public void EuroADolarYBitcoin_ConversionCorrecta()
        {
            formulario.txtEuro.Text = "100";
            double dolaresEsperados = 122;
            double bitcoinsEsperados = 0.0028;

            formulario.btnConvertirMoneda_Click(null, null);

            Assert.AreEqual(dolaresEsperados, double.Parse(formulario.txtDolar.Text));
            Assert.AreEqual(bitcoinsEsperados, double.Parse(formulario.txtBitcoin.Text));
        }

        [Test]
        public void EuroADolarYBitcoin_EntradaInvalida()
        {
            formulario.txtEuro.Text = "no es un número";

            formulario.btnConvertirMoneda_Click(null, null);

            Assert.IsTrue(string.IsNullOrEmpty(formulario.txtDolar.Text));
            Assert.IsTrue(string.IsNullOrEmpty(formulario.txtBitcoin.Text));
        }

        [Test]
        public void EuroADolarYBitcoin_NoSeRealizaConversion()
        {
            formulario.txtEuro.Text = "-10";

            formulario.btnConvertirTemperatura_Click(null, null);

            Assert.IsTrue(string.IsNullOrEmpty(formulario.txtDolar.Text));
            Assert.IsTrue(string.IsNullOrEmpty(formulario.txtBitcoin.Text));
        }

        [Test]
        public void DolarAEuroYBitcoin_ConversionCorrecta()
        {
            formulario.txtDolar.Text = "100";
            double eurosEsperados = 82;
            double bitcoinsEsperados = 0.0023;

            formulario.btnConvertirMoneda_Click(null, null);

            Assert.AreEqual(eurosEsperados, double.Parse(formulario.txtEuro.Text));
            Assert.AreEqual(bitcoinsEsperados, double.Parse(formulario.txtBitcoin.Text));
        }

        [Test]
        public void DolarAEuroYBitcoin_EntradaInvalida()
        {
            formulario.txtDolar.Text = "no es un número";

            formulario.btnConvertirMoneda_Click(null, null);

            Assert.IsTrue(string.IsNullOrEmpty(formulario.txtEuro.Text));
            Assert.IsTrue(string.IsNullOrEmpty(formulario.txtBitcoin.Text));
        }

        [Test]
        public void DolarAEuroYBitcoin_NoSeRealizaConversion()
        {
            formulario.txtDolar.Text = "-10";

            formulario.btnConvertirTemperatura_Click(null, null);

            Assert.IsTrue(string.IsNullOrEmpty(formulario.txtEuro.Text));
            Assert.IsTrue(string.IsNullOrEmpty(formulario.txtBitcoin.Text));
        }

        [Test]
        public void BitcoinAEuroYDolar_ConversionCorrecta()
        {
            formulario.txtBitcoin.Text = "1";
            double eurosEsperados = 35604.60;
            double dolaresEsperados = 44193.94;

            formulario.btnConvertirMoneda_Click(null, null);

            Assert.AreEqual(eurosEsperados, double.Parse(formulario.txtEuro.Text));
            Assert.AreEqual(dolaresEsperados, double.Parse(formulario.txtDolar.Text));
        }

        [Test]
        public void BitcoinAEuroYDolar_EntradaInvalida()
        {
            formulario.txtBitcoin.Text = "no es un número";

            formulario.btnConvertirMoneda_Click(null, null);

            Assert.IsTrue(string.IsNullOrEmpty(formulario.txtEuro.Text));
            Assert.IsTrue(string.IsNullOrEmpty(formulario.txtDolar.Text));
        }

        [Test]
        public void BitcoinAEuroYDolar_NoSeRealizaConversion()
        {
            formulario.txtBitcoin.Text = "-10";

            formulario.btnConvertirTemperatura_Click(null, null);

            Assert.IsTrue(string.IsNullOrEmpty(formulario.txtEuro.Text));
            Assert.IsTrue(string.IsNullOrEmpty(formulario.txtDolar.Text));
        }
    }
}