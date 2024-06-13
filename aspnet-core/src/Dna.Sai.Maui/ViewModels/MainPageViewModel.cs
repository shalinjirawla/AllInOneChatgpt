using CommunityToolkit.Mvvm.Input;
using Volo.Abp.DependencyInjection;

namespace Dna.Sai.Maui.ViewModels;

public partial class MainPageViewModel : SaiViewModelBase, ITransientDependency
{
    public MainPageViewModel()
    {
    }

    [RelayCommand]
    async Task SeeAllUsers()
    {
        await Shell.Current.GoToAsync("///users");
    }
}
