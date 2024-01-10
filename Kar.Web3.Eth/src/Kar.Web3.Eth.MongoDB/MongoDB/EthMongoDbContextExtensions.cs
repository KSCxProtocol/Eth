using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Kar.Web3.Eth.MongoDB;

public static class EthMongoDbContextExtensions
{
    public static void ConfigureEth(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
