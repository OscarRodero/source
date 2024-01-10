namespace EjemploMAUI;

public partial class PaginaPrueba : ContentPage
{
	public PaginaPrueba()
	{
		InitializeComponent();
	}

    private void btnVolver_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void btnSeguir_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}