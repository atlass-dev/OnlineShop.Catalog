using AutoMapper;
using MediatR;
using OnlineShop.Catalog.Abstractions.Interfaces.Database;
using OnlineShop.Catalog.Domain.Entities;

namespace OnlineShop.Catalog.UseCases.Products.Commands.UpdateProduct;

/// <summary>
/// Handler for <see cref="UpdateProductCommand"/>.
/// </summary>
public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
{
    private readonly IAppDbContext dbContext;
    private readonly IMapper mapper;

    /// <summary>
    /// Constructor.
    /// </summary>
    public UpdateProductCommandHandler(IAppDbContext dbContext, IMapper mapper)
    {
        this.dbContext = dbContext;
        this.mapper = mapper;
    }

    /// <inheritdoc/>
    public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        var product = mapper.Map<Product>(request);

        dbContext.Products.Update(product);

        await dbContext.SaveChangesAsync(cancellationToken);
    }
}
