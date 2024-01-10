using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Kar.Web3.Eth.EntityFrameworkCore;

[ConnectionStringName(EthDbProperties.ConnectionStringName)]
public class EthDbContext : AbpDbContext<EthDbContext>, IEthDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public EthDbContext(DbContextOptions<EthDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureEth();
    }
}
