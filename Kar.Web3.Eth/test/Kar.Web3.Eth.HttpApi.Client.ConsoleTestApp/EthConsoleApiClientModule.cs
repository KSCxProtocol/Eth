using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Kar.Web3.Eth;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(EthHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class EthConsoleApiClientModule : AbpModule
{

}
