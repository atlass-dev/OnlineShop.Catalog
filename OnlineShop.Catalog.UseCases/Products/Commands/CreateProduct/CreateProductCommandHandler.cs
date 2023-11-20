using AutoMapper;
using MediatR;
using OnlineShop.Catalog.Abstractions.Interfaces.Database;
using OnlineShop.Catalog.Domain.Entities;

namespace OnlineShop.Catalog.UseCases.Products.Commands.CreateProduct;

/// <summary>
/// Handler for <see cref="CreateProductCommand"/>.
/// </summary>
internal class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
{
    private readonly IAppDbContext dbContext;
    private readonly IMapper mapper;

    /// <summary>
    /// Constructor.
    /// </summary>
    public CreateProductCommandHandler(IAppDbContext dbContext, IMapper mapper)
    {
        this.dbContext = dbContext;
        this.mapper = mapper;
    }

    /// <inheritdoc/>
    public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = mapper.Map<Product>(request);

        await dbContext.Products.AddAsync(product, cancellationToken);
        await dbContext.SaveChangesAsync(cancellationToken);

        return product.Id;
    }
}
