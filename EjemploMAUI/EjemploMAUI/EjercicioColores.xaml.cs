namespace EjemploMAUI
{
    public partial class EjercicioColores : ContentPage
    {
        private Random random = new Random();
        private int valorRojo;
        private int valorVerde;
        private int valorAzul;

        public EjercicioColores()
        {
            InitializeComponent();
        }

        private void R_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            valorRojo = Convert.ToInt32(R.Value);
            Texto_Rojo.Text = "Valor Rojo: " + valorRojo.ToString();
            ActualizarColorDeFondo();
        }

        private void G_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            valorVerde = Convert.ToInt32(G.Value);
            Texto_Verde.Text = "Valor Verde: " + valorVerde.ToString();
            ActualizarColorDeFondo();
        }

        private void B_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            valorAzul = Convert.ToInt32(B.Value);
            Texto_Azul.Text = "Valor Azul: " + valorAzul.ToString();
            ActualizarColorDeFondo();
        }

        private void Color_Aleatorio_Clicked(object sender, EventArgs e)
        {
            valorRojo = random.Next(256);
            valorVerde = random.Next(256);
            valorAzul = random.Next(256);
            R.Value = valorRojo;
            G.Value = valorVerde;
            B.Value = valorAzul;
            Texto_Rojo.Text = "Valor Rojo: " + valorRojo.ToString();
            Texto_Verde.Text = "Valor Verde: " + valorVerde.ToString();
            Texto_Azul.Text = "Valor Azul: " + valorAzul.ToString();
            ActualizarColorDeFondo();
        }

        private void ActualizarColorDeFondo()
        {
            Color colorFondo = Color.FromRgb(valorRojo, valorVerde, valorAzul);
            this.BackgroundColor = colorFondo;
            Color_Aleatorio.BackgroundColor = colorFondo;
            int suma = (valorRojo + valorAzul + valorVerde)/3;
            if (suma > 128)
            {
                Color_Aleatorio.TextColor = Color.FromRgb(0, 0, 0);
                Texto_Rojo.TextColor= Color.FromRgb(0, 0, 0);
                Texto_Verde.TextColor= Color.FromRgb(0, 0, 0);
                Texto_Azul.TextColor= Color.FromRgb(0, 0, 0);
                Título.TextColor = Color.FromRgb(0, 0, 0);
            }
            else 
            {
                Color_Aleatorio.TextColor=Color.FromRgb(255,255,255);
                Texto_Rojo.TextColor = Color.FromRgb(255, 255, 255);
                Texto_Verde.TextColor = Color.FromRgb(255, 255, 255);
                Texto_Azul.TextColor = Color.FromRgb(255, 255, 255);
                Título.TextColor = Color.FromRgb(255, 255, 255);
            }
            string hexadecimal = colorFondo.ToHex().ToString();
            lblHex.Text = hexadecimal;
        }

        private async void Copiar_Clicked(object sender, EventArgs e)
        {
            Color colorFondo = Color.FromRgb(valorRojo, valorVerde, valorAzul);
            string hexadecimal = colorFondo.ToHex().ToString();
            Clipboard.SetTextAsync(hexadecimal);
            var toast = CommunityToolkit.Maui.Alerts.Toast.Make("Color copiado al portapapeles",
            CommunityToolkit.Maui.Core.ToastDuration.Short, 12);
            await toast.Show();
        }
    }
}
