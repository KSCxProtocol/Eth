using Volo.Abp.Modularity;

namespace Kar.Web3.Eth;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class EthDomainTestBase<TStartupModule> : EthTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
