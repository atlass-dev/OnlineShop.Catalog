using MediatR;

namespace OnlineShop.Catalog.UseCases.Products.Queries.GetProductById;

/// <summary>
/// Gets product by id.
/// </summary>
/// <param name="ProductId">Product's id.</param>
public record GetProductByIdQuery(int ProductId) : IRequest<ProductDto>;
