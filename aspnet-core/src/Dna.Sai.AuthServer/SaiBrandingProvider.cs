using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Dna.Sai;

[Dependency(ReplaceServices = true)]
public class SaiBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Sai";
}
