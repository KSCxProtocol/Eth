using Kar.Web3.Eth.Localization;
using Volo.Abp.Application.Services;

namespace Kar.Web3.Eth;

public abstract class EthAppService : ApplicationService
{
    protected EthAppService()
    {
        LocalizationResource = typeof(EthResource);
        ObjectMapperContext = typeof(EthApplicationModule);
    }
}
