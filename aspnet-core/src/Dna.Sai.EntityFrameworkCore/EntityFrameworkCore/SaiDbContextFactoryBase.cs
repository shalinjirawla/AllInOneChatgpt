﻿using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Dna.Sai.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public abstract class SaiDbContextFactoryBase<TDbContext> : IDesignTimeDbContextFactory<TDbContext>
    where TDbContext : DbContext
{
    public TDbContext CreateDbContext(string[] args)
    {
        SaiEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<TDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return CreateDbContext(builder.Options);
    }

    protected abstract TDbContext CreateDbContext(DbContextOptions<TDbContext> dbContextOptions);

    protected IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Dna.Sai.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
