using Kar.Web3.Eth.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Kar.Web3.Eth;

public abstract class EthController : AbpControllerBase
{
    protected EthController()
    {
        LocalizationResource = typeof(EthResource);
    }
}
