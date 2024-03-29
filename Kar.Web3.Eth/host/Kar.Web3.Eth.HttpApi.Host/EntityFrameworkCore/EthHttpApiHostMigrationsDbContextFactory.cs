﻿using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Kar.Web3.Eth.EntityFrameworkCore;

public class EthHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<EthHttpApiHostMigrationsDbContext>
{
    public EthHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<EthHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Eth"));

        return new EthHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
