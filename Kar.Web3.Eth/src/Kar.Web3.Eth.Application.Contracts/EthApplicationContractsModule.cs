using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Kar.Web3.Eth;

[DependsOn(
    typeof(EthDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class EthApplicationContractsModule : AbpModule
{

}
