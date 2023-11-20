using MediatR;
using OnlineShop.Catalog.UseCases.Products.Commands.CreateProduct;

namespace OnlineShop.Catalog.Infrastructure.DependencyInjection;

/// <summary>
/// Register Mediator as dependency.
/// </summary>
internal static class MediatRModule
{
    /// <summary>
    /// Register dependencies.
    /// </summary>
    /// <param name="services">Services.</param>
    public static void Register(IServiceCollection services)
    {
        var useCasesAssembly = typeof(CreateProductCommand).Assembly;

        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(useCasesAssembly));
    }
}
