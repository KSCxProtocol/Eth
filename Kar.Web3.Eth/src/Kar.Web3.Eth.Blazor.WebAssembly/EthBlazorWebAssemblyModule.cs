using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace Kar.Web3.Eth.Blazor.WebAssembly;

[DependsOn(
    typeof(EthBlazorModule),
    typeof(EthHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class EthBlazorWebAssemblyModule : AbpModule
{

}
