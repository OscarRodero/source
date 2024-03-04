using System;
using System.Windows.Forms;

namespace PruebasUnitarias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void btnConvertirTemperatura_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCelsius.Text))
            {
                if (double.TryParse(txtCelsius.Text, out double celsius))
                {
                    if (celsius >= 0)
                    {
                        double fahrenheit = (celsius * 9 / 5) + 32;
                        txtFarenheit.Text = fahrenheit.ToString();
                    }
                    else
                    {
                        MessageBox.Show("La temperatura en Celsius no puede ser negativa.");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un valor válido para Celsius.");
                }
            }
            else if (!string.IsNullOrEmpty(txtFarenheit.Text))
            {
                if (double.TryParse(txtFarenheit.Text, out double fahrenheit))
                {
                    if (fahrenheit >= 0)
                    {
                        double celsius = (fahrenheit - 32) * 5 / 9;
                        txtCelsius.Text = celsius.ToString();
                    }
                    else
                    {
                        MessageBox.Show("La temperatura en Fahrenheit no puede ser negativa.");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un valor válido para Fahrenheit.");
                }
            }
        }

        public void btnConvertirDistancia_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPasos.Text))
            {
                if (double.TryParse(txtPasos.Text, out double pasos))
                {
                    if (pasos >= 0)
                    {
                        double millas = pasos * 0.000473484848;
                        txtMillas.Text = millas.ToString();

                        double kilometros = pasos * 0.000762;
                        txtKilometros.Text = kilometros.ToString();
                    }
                    else
                    {
                        MessageBox.Show("La cantidad de pasos no puede ser negativa.");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un valor válido para Pasos.");
                }
            }
            else if (!string.IsNullOrEmpty(txtKilometros.Text))
            {
                if (double.TryParse(txtKilometros.Text, out double kilometros))
                {
                    if (kilometros >= 0)
                    {
                        double pasos = kilometros * 1312.34;
                        txtPasos.Text = pasos.ToString();

                        double millas = kilometros * 0.621371;
                        txtMillas.Text = millas.ToString();
                    }
                    else
                    {
                        MessageBox.Show("La cantidad de kilómetros no puede ser negativa.");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un valor válido para Kilómetros.");
                }
            }
            else if (!string.IsNullOrEmpty(txtMillas.Text))
            {
                if (double.TryParse(txtMillas.Text, out double millas))
                {
                    if (millas >= 0)
                    {
                        double pasos = millas * 2112;
                        txtPasos.Text = pasos.ToString();

                        double kilometros = millas * 1.60934;
                        txtKilometros.Text = kilometros.ToString();
                    }
                    else
                    {
                        MessageBox.Show("La cantidad de millas no puede ser negativa.");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un valor válido para Millas.");
                }
            }
        }

        public void btnConvertirMoneda_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEuro.Text))
            {
                if (double.TryParse(txtEuro.Text, out double euro))
                {
                    if (euro >= 0)
                    {
                        double dolar = euro * 1.22;
                        txtDolar.Text = dolar.ToString();

                        double bitcoin = euro * 0.000028;
                        txtBitcoin.Text = bitcoin.ToString();
                    }
                    else
                    {
                        MessageBox.Show("La cantidad de Euros no puede ser negativa.");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un valor válido para Euro.");
                }
            }
            else if (!string.IsNullOrEmpty(txtDolar.Text))
            {
                if (double.TryParse(txtDolar.Text, out double dolar))
                {
                    if (dolar >= 0)
                    {
                        double euro = dolar * 0.82;
                        txtEuro.Text = euro.ToString();

                        double bitcoin = dolar * 0.000023;
                        txtBitcoin.Text = bitcoin.ToString();
                    }
                    else
                    {
                        MessageBox.Show("La cantidad de Dólares no puede ser negativa.");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un valor válido para Dólar.");
                }
            }
            else if (!string.IsNullOrEmpty(txtBitcoin.Text))
            {
                if (double.TryParse(txtBitcoin.Text, out double bitcoin))
                {
                    if (bitcoin >= 0)
                    {
                        double euro = bitcoin * 35604.60;
                        txtEuro.Text = euro.ToString();

                        double dolar = bitcoin * 44193.94;
                        txtDolar.Text = dolar.ToString();
                    }
                    else
                    {
                        MessageBox.Show("La cantidad de Bitcoins no puede ser negativa.");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un valor válido para Bitcoin.");
                }
            }
        }
    }
}
