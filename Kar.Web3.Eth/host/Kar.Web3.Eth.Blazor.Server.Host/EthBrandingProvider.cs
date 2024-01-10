using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Kar.Web3.Eth.Blazor.Server.Host;

[Dependency(ReplaceServices = true)]
public class EthBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Eth";
}
