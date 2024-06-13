using Dna.Sai.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Dna.Sai.Web.Public.Pages;

/* Inherit your Page Model classes from this class.
 */
public abstract class SaiPublicPageModel : AbpPageModel
{
    protected SaiPublicPageModel()
    {
        LocalizationResourceType = typeof(SaiResource);
    }
}
