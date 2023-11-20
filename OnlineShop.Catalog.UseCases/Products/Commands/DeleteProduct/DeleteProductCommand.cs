using MediatR;

namespace OnlineShop.Catalog.UseCases.Products.Commands.DeleteProduct;

/// <summary>
/// Deletes product by it's id.
/// </summary>
/// <param name="ProductId">Product id.</param>
public record DeleteProductCommand(int ProductId) : IRequest;
