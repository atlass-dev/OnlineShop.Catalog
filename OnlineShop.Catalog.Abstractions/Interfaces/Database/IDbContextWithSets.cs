using Microsoft.EntityFrameworkCore;

namespace OnlineShop.Catalog.Abstractions.Interfaces.Database;

/// <summary>
/// Database context that can retrieve collection by provided type.
/// </summary>
public interface IDbContextWithSets
{
    /// <summary>
    /// Get the set of entities by type.
    /// </summary>
    /// <typeparam name="TEntity">Entity type.</typeparam>
    /// <returns>Set of entities.</returns>
    DbSet<TEntity> Set<TEntity>() where TEntity : class;

    /// <summary>
    /// Save pending changes.
    /// </summary>
    /// <param name="cancellationToken">Token to cancel the request.</param>
    /// <returns>Number of affected rows.</returns>
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
