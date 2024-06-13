using Dna.Sai.Maui.Storage;
using Volo.Abp.DependencyInjection;

namespace Dna.Sai.Maui.Settings;

public class ThemeManager : ISingletonDependency
{
    private readonly IStorage _storage;

    public ThemeManager(IStorage storage)
    {
        _storage = storage;
    }

    public async Task<AppTheme> GetAppThemeAsync()
    {
        var storedTheme = await _storage.GetAsync(SaiConsts.Settings.Theme);

        if (!storedTheme.IsNullOrEmpty())
        {
            return Enum.Parse<AppTheme>(storedTheme);
        }

        return AppTheme.Unspecified;
    }

    public async Task SetAppThemeAsync(AppTheme theme)
    {
        App.Current!.UserAppTheme = theme;

        await _storage.SetAsync(SaiConsts.Settings.Theme, theme.ToString());
    }
}