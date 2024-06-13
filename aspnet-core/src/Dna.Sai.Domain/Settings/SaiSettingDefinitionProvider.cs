using Volo.Abp.Settings;

namespace Dna.Sai.Settings;

public class SaiSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(SaiSettings.MySetting1));
    }
}
