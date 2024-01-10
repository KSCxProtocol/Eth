using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Kar.Web3.Eth.EntityFrameworkCore;

public class EthHttpApiHostMigrationsDbContext : AbpDbContext<EthHttpApiHostMigrationsDbContext>
{
    public EthHttpApiHostMigrationsDbContext(DbContextOptions<EthHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureEth();
    }
}
