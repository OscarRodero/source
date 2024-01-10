namespace EjemploMAUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //var paginita = new NavigationPage(new MainPage());
            //paginita.BarBackground = Colors.MidnightBlue;
            //paginita.BarTextColor = Colors.GreenYellow;
            MainPage = new AbsolutePrueba();
        }
    }
}