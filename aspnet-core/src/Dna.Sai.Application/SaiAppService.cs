using Dna.Sai.Localization;
using Volo.Abp.Application.Services;

namespace Dna.Sai;

/* Inherit your application services from this class.
 */
public abstract class SaiAppService : ApplicationService
{
    protected SaiAppService()
    {
        LocalizationResource = typeof(SaiResource);
    }
}
