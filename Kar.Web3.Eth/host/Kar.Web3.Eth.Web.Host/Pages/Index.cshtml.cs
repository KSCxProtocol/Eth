using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Kar.Web3.Eth.Pages;

public class IndexModel : EthPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
