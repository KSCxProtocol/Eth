using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Kar.Web3.Eth;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(EthDomainSharedModule)
)]
public class EthDomainModule : AbpModule
{

}
