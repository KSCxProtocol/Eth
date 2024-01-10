using Volo.Abp.Modularity;

namespace Kar.Web3.Eth;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class EthApplicationTestBase<TStartupModule> : EthTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
