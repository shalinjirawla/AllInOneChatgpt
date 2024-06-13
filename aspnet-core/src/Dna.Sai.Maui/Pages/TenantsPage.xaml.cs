using Dna.Sai.Maui.ViewModels;
using Volo.Abp.DependencyInjection;

namespace Dna.Sai.Maui.Pages;

public partial class TenantsPage : ContentPage, ITransientDependency
{
	public TenantsPage(TenantsPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
