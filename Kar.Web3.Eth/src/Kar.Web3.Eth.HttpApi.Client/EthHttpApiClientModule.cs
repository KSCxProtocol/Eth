using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Kar.Web3.Eth;

[DependsOn(
    typeof(EthApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class EthHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(EthApplicationContractsModule).Assembly,
            EthRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<EthHttpApiClientModule>();
        });

    }
}
