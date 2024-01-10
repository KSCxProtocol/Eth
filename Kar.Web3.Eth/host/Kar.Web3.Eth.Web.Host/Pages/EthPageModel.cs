using Kar.Web3.Eth.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Kar.Web3.Eth.Pages;

public abstract class EthPageModel : AbpPageModel
{
    protected EthPageModel()
    {
        LocalizationResourceType = typeof(EthResource);
    }
}
