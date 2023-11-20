using AutoMapper;
using OnlineShop.Catalog.Domain.Entities;
using OnlineShop.Catalog.UseCases.Products.Commands.CreateProduct;

namespace OnlineShop.Catalog.UseCases.Products;

/// <summary>
/// Products mapping profile.
/// </summary>
internal class ProductsMappingProfile : Profile
{
    /// <summary>
    /// Constructor.
    /// </summary>
    public ProductsMappingProfile()
    {
        CreateMap<CreateProductCommand, Product>()
            .ForMember(p => p.Images, opt => opt.MapFrom(command => command.ImagesPaths.Select(path => new ProductImage { Url = path })));
    }
}
