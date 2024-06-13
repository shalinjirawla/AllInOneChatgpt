using Dna.Sai.Maui.ViewModels;
using Volo.Abp.DependencyInjection;

namespace Dna.Sai.Maui.Pages;

public partial class LoginOrLogoutPage : ContentPage, ITransientDependency
{
	public LoginOrLogoutPage(LoginOrLogoutViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}