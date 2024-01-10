using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace Kar.Web3.Eth.Blazor.Server;

[DependsOn(
    typeof(AbpAspNetCoreComponentsServerThemingModule),
    typeof(EthBlazorModule)
    )]
public class EthBlazorServerModule : AbpModule
{

}
