using ServiciosRest.MVVM.Views;

namespace ServiciosRest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new UsuariosView());
        }
    }
}
