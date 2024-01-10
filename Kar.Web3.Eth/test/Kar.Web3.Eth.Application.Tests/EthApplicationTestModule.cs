using Volo.Abp.Modularity;

namespace Kar.Web3.Eth;

[DependsOn(
    typeof(EthApplicationModule),
    typeof(EthDomainTestModule)
    )]
public class EthApplicationTestModule : AbpModule
{

}
