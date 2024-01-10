using Kar.Web3.Eth.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Kar.Web3.Eth.Blazor.Server.Host;

public abstract class EthComponentBase : AbpComponentBase
{
    protected EthComponentBase()
    {
        LocalizationResource = typeof(EthResource);
    }
}
