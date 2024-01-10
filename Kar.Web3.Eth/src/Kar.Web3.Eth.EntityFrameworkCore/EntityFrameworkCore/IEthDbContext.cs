using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Kar.Web3.Eth.EntityFrameworkCore;

[ConnectionStringName(EthDbProperties.ConnectionStringName)]
public interface IEthDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
