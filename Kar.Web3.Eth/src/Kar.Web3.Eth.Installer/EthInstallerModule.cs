using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Kar.Web3.Eth;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class EthInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<EthInstallerModule>();
        });
    }
}
