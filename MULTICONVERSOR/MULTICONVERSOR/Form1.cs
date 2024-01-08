using MULTICONVERSOR.Modelo;

namespace MULTICONVERSOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            Conversor c = new Conversor();
            if (celsiusFarenheit.Text.Length > 0) 
            {
                celsiusFarenheit = c.celsiusFarenheit(celsiusFarenheit.Text);
            }
            if(farenheitCelsius.Text.Length > 0) 
            {
                farenheitCelsius = c.farenheitCelsius(farenheitCelsius.Text);
            }
            if (pasosKilometros.Text.Length > 0) 
            {
            
            }
            if (kilometrosPasos.Text.Length > 0)
            { 
            
            }
            if (pasosMillas.Text.Length > 0)
            { 
            
            }
            if (millasPasos.Text.Length > 0)
            { 

            }
            if (kilometrosMillas.Text.Length > 0) 
            { 
            
            }
            if (millasKilometros.Text.Length > 0) 
            {
            
            }
            if (euroDolar.Text.Length > 0) 
            {
            
            }
            if(dolarEuro.Text.Length > 0) 
            {
            
            }
            if(euroBitcoin.Text.Length > 0)
            {

            }
            if (bitcoinEuro.Text.Length > 0)
            { 
            
            }
            if (dolarBitcoin.Text.Length > 0)
            { 
            
            }
            if (bitcoinDolar.Text.Length > 0) 
            {
            
            }
        }
    }
}