using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Kar.Web3.Eth;

[Dependency(ReplaceServices = true)]
public class EthBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Eth";
}
