using Dna.Sai.Maui.ViewModels;
using Volo.Abp.DependencyInjection;

namespace Dna.Sai.Maui;

public partial class MainPage : ContentPage, ITransientDependency
{
    public MainPage(
		MainPageViewModel vm)
	{
        BindingContext = vm;
        InitializeComponent();
    }
}