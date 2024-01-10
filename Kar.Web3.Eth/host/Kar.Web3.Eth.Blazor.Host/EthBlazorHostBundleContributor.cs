using Volo.Abp.Bundling;

namespace Kar.Web3.Eth.Blazor.Host;

public class EthBlazorHostBundleContributor : IBundleContributor
{
    public void AddScripts(BundleContext context)
    {

    }

    public void AddStyles(BundleContext context)
    {
        context.Add("main.css", true);
    }
}
