using Volo.Abp.Modularity;

namespace Kar.Web3.Eth;

[DependsOn(
    typeof(EthDomainModule),
    typeof(EthTestBaseModule)
)]
public class EthDomainTestModule : AbpModule
{

}
