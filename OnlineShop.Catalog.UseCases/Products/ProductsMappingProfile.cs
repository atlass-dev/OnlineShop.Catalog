using AutoMapper;
using OnlineShop.Catalog.Domain.Entities;
using OnlineShop.Catalog.UseCases.Products.Commands.CreateProduct;
using OnlineShop.Catalog.UseCases.Products.Commands.UpdateProduct;
using OnlineShop.Catalog.UseCases.Products.Queries.GetProductById;

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
        CreateMap<Product, ProductDto>()
            .ForMember(dto => dto.Brand, opt => opt.MapFrom(p => p.Brand.Name))
            .ForMember(dto => dto.Category, opt => opt.MapFrom(p => p.Category.Name));
        CreateMap<UpdateProductCommand, Product>();

        CreateMap<ProductImage, ProductImageDto>();
        CreateMap<ProductImageDto, ProductImage>();
    }
}
