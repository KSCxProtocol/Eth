using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace Kar.Web3.Eth;

[DependsOn(
    typeof(EthDomainModule),
    typeof(EthApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule)
    )]
public class EthApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<EthApplicationModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<EthApplicationModule>(validate: true);
        });
    }
}
