using Localization.Resources.AbpUi;
using Kar.Web3.Eth.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Kar.Web3.Eth;

[DependsOn(
    typeof(EthApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class EthHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(EthHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<EthResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
