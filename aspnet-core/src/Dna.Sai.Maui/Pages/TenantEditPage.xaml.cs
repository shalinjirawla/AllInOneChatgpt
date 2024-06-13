using Dna.Sai.Maui.ViewModels;
using Volo.Abp.DependencyInjection;

namespace Dna.Sai.Maui.Pages;

public partial class TenantEditPage : ContentPage, ITransientDependency
{
	public TenantEditPage(TenantEditViewModel vm)
	{
		BindingContext = vm;
		InitializeComponent();
	}
}
