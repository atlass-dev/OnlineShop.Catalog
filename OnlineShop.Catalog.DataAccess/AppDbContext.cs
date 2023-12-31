﻿using Microsoft.EntityFrameworkCore;
using OnlineShop.Catalog.Abstractions.Interfaces.Database;
using OnlineShop.Catalog.Domain.Entities;

namespace OnlineShop.Catalog.DataAccess;

/// <inheritdoc cref="IAppDbContext"/>
public class AppDbContext : DbContext, IAppDbContext
{
    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="options">Database context options.</param>
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    /// <inheritdoc/>
    public DbSet<Product> Products { get; protected set; }

    /// <inheritdoc/>
    public DbSet<Category> Categories { get; protected set; }

    /// <inheritdoc/>
    public DbSet<Brand> Brands { get; protected set; }

    /// <inheritdoc/>
    public DbSet<ProductImage> ProductImages { get; protected set; }

    /// <inheritdoc/>
    public DbSet<BrandImage> BrandImages { get; protected set; }

    /// <inheritdoc/>
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        RestrictCascadeDelete(builder);
        ConfigureProducts(builder);
        ConfigureBrands(builder);
    }

    private void RestrictCascadeDelete(ModelBuilder builder)
    {
        foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
        {
            relationship.DeleteBehavior = DeleteBehavior.Restrict;
        }
    }

    private void ConfigureProducts(ModelBuilder builder)
    {
        builder.Entity<Product>()
            .HasMany(p => p.Images)
            .WithOne()
            .OnDelete(DeleteBehavior.Cascade);
    }

    private void ConfigureBrands(ModelBuilder builder)
    {
        builder.Entity<Brand>()
            .HasMany(b => b.Images)
            .WithOne()
            .OnDelete(DeleteBehavior.Cascade);
    }
}
