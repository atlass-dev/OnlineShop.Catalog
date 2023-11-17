using Microsoft.EntityFrameworkCore;
using OnlineShop.Catalog.Domain.Entities;

namespace OnlineShop.Catalog.Abstractions.Interfaces.Database;

/// <summary>
/// Database context.
/// </summary>
public interface IAppDbContext : IDbContextWithSets, IDisposable
{
    /// <summary>
    /// Products.
    /// </summary>
    DbSet<Product> Products { get; }

    /// <summary>
    /// Categories.
    /// </summary>
    DbSet<Category> Categories { get; }

    /// <summary>
    /// Brands.
    /// </summary>
    DbSet<Brand> Brands { get; }
}
