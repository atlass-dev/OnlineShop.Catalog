﻿using Microsoft.EntityFrameworkCore;
using OnlineShop.Catalog.DataAccess;

namespace OnlineShop.Catalog.Infrastructure.Startup;

/// <summary>
/// Database context setup.
/// </summary>
internal class DbContextOptionsSetup
{
    private readonly string connectionString;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="connectionString">Connection string.</param>
    public DbContextOptionsSetup(string connectionString)
    {
        this.connectionString = connectionString;
    }

    /// <summary>
    /// Setups database context.
    /// </summary>
    /// <param name="options">Options.</param>
    public void Setup(DbContextOptionsBuilder options)
    {
        options.UseNpgsql(connectionString,
            opt => opt.MigrationsAssembly(typeof(AppDbContext).Assembly.GetName().Name));
    }
}
