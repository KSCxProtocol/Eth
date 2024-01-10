using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Kar.Web3.Eth.MongoDB;

[ConnectionStringName(EthDbProperties.ConnectionStringName)]
public interface IEthMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
