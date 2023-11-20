using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Catalog.UseCases.Products.Commands.CreateProduct;

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
    /// Creates product.
    /// </summary>
    /// <param name="command">Command.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Id of created product.</returns>
    [HttpPost]
    public async Task<int> CreateProduct([FromBody] CreateProductCommand command, CancellationToken cancellationToken)
    {
        return await mediator.Send(command, cancellationToken);
    }
}
