using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Catalog.Abstractions.Interfaces.Database;

namespace OnlineShop.Catalog.UseCases.Products.Queries.GetProductById;

/// <summary>
/// Handler for <see cref="GetProductByIdQuery"/>.
/// </summary>
internal class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ProductDto>
{
    private readonly IAppDbContext dbContext;
    private readonly IMapper mapper;

    /// <summary>
    /// Constructor.
    /// </summary>
    public GetProductByIdQueryHandler(IAppDbContext dbContext, IMapper mapper)
    {
        this.dbContext = dbContext;
        this.mapper = mapper;
    }

    /// <inheritdoc/>
    public async Task<ProductDto> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        var product = await dbContext.Products
            .AsNoTracking()
            .ProjectTo<ProductDto>(mapper.ConfigurationProvider)
            .FirstOrDefaultAsync(p => p.Id == request.ProductId, cancellationToken);

        if (product != null)
        {
            return product;
        }

        throw new KeyNotFoundException($"Product with id {request.ProductId} doesn't exist.");
    }
}
