using Dna.Sai.Maui.ViewModels;
using Volo.Abp.DependencyInjection;

namespace Dna.Sai.Maui.Pages;

public partial class IdentityUserCreateModalPage : ContentPage, ITransientDependency
{
    public IdentityUserCreateModalPage(IdentityUserCreateViewModel vm)
    {
        BindingContext = vm;
        InitializeComponent();
    }
}