using Kar.Web3.Eth.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Kar.Web3.Eth.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class EthPageModel : AbpPageModel
{
    protected EthPageModel()
    {
        LocalizationResourceType = typeof(EthResource);
        ObjectMapperContext = typeof(EthWebModule);
    }
}
