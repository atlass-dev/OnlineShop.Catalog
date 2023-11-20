using MediatR;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Catalog.Abstractions.Interfaces.Database;

namespace OnlineShop.Catalog.UseCases.Products.Commands.DeleteProduct;

/// <summary>
/// Handler for <see cref="DeleteProductCommand"/>.
/// </summary>
public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand>
{
    private readonly IAppDbContext dbContext;

    /// <summary>
    /// Constructor.
    /// </summary>
    public DeleteProductCommandHandler(IAppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    /// <inheritdoc/>
    public async Task Handle(DeleteProductCommand request, CancellationToken cancellationToken)
    {
        await dbContext.Products
            .Where(p => p.Id == request.ProductId)
            .ExecuteDeleteAsync(cancellationToken);
    }
}
