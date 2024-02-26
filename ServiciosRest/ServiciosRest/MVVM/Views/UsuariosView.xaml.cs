using ServiciosRest.MVVM.ViewModels;

namespace ServiciosRest.MVVM.Views;

public partial class UsuariosView : ContentPage
{
	public UsuariosView()
	{
		InitializeComponent();
		BindingContext = new UsuariosViewModel();
	}
}