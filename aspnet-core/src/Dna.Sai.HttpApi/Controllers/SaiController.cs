using Dna.Sai.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Dna.Sai.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class SaiController : AbpControllerBase
{
    protected SaiController()
    {
        LocalizationResource = typeof(SaiResource);
    }
}
