using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Catalog.UseCases.Products.Commands.CreateProduct;
using OnlineShop.Catalog.UseCases.Products.Commands.DeleteProduct;
using OnlineShop.Catalog.UseCases.Products.Commands.UpdateProduct;
using OnlineShop.Catalog.UseCases.Products.Queries.GetProductById;

namespace OnlineShop.Catalog.Controllers;

/// <summary>
/// Products controller.
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IMediator mediator;

    /// <summary>
    /// Constructor.
    /// </summary>
    public ProductsController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    /// <summary>
    /// Gets product by id.
    /// </summary>
    /// <param name="productId">Product id.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Product.</returns>
    [HttpGet]
    public async Task<ProductDto> GetById(int productId, CancellationToken cancellationToken)
    {
        return await mediator.Send(new GetProductByIdQuery(productId), cancellationToken);
    }

    /// <summary>
    /// Creates product.
    /// </summary>
    /// <param name="command">Command.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Id of created product.</returns>
    [HttpPost]
    public async Task<int> Create([FromBody] CreateProductCommand command, CancellationToken cancellationToken)
    {
        return await mediator.Send(command, cancellationToken);
    }

    /// <summary>
    /// Deletes product by id.
    /// </summary>
    /// <param name="productId">Product id.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    [HttpDelete]
    public async Task Delete(int productId, CancellationToken cancellationToken)
    {
        await mediator.Send(new DeleteProductCommand(productId), cancellationToken);
    }

    /// <summary>
    /// Updates product.
    /// </summary>
    /// <param name="command">Command.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    [HttpPut]
    public async Task Update([FromBody] UpdateProductCommand command, CancellationToken cancellationToken)
    {
        await mediator.Send(command, cancellationToken);
    }
}
