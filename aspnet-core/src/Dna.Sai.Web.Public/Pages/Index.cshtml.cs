using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Dna.Sai.Web.Public.Pages;

public class IndexModel : SaiPublicPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
