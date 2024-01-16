namespace Propinas
{
    public partial class MainPage : ContentPage
    {
        float factura = 0.0f;
        int porcentaje = 0;
        int numeroPersonas = 1;
        float total_por_persona;
        float subtotal_por_persona;
        float totalPropina_por_persona;

        public MainPage()
        {
            InitializeComponent();
        }

        private void actualizarValores()
        {
            calcularPropina();
            lblTotal.Text = total_por_persona.ToString();
            lblSubtotal.Text = subtotal_por_persona.ToString();
            lblPropinaPorPersona.Text = totalPropina_por_persona.ToString();
            lblNumPersonas.Text = numeroPersonas.ToString();
            sldPropina.Value = porcentaje;
        }
        private void calcularPropina()
        {
            if (factura != 0) {
                totalPropina_por_persona = (factura * (porcentaje / 100)) / numeroPersonas;
                subtotal_por_persona = (factura - (totalPropina_por_persona * numeroPersonas)) / numeroPersonas;
                total_por_persona = subtotal_por_persona + totalPropina_por_persona;
            }
        }
        private void txtCuenta_Completed(object sender, EventArgs e)
        {
            float resultado;
            if (float.TryParse(txtCuenta.Text, out resultado))
            {
                factura = resultado;
                actualizarValores();
            }
        }        

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(sender is Button boton)
            {
                if (boton.Text == "10%")
                {
                    porcentaje = 10;
                }
                else if (boton.Text == "15%")
                {
                    porcentaje = 15;
                }
                else if (boton.Text == "20%")
                {
                    porcentaje = 20;
                }
                actualizarValores();
            }
        }

        private void sldPropina_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            porcentaje = (int)sldPropina.Value;
            actualizarValores();
        }        

        private void btnMenos_Clicked(object sender, EventArgs e)
        {
            if (numeroPersonas != 1) {
                numeroPersonas -= 1;
            }
            actualizarValores();
        }

        private void btnMas_Clicked(object sender, EventArgs e)
        {
            numeroPersonas += 1;
            actualizarValores();
        }
    }

}
