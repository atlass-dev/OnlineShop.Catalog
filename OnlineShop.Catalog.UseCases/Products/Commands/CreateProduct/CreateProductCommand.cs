using MediatR;
using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Catalog.UseCases.Products.Commands.CreateProduct;

/// <summary>
/// Creates product.
/// </summary>
public record CreateProductCommand : IRequest<int>
{
    /// <summary>
    /// Product's name.
    /// </summary>
    [Length(5, 50, ErrorMessage = "Product's name length must be within range from 5 to 50 symbols.")]
    required public string Name { get; set; }

    /// <summary>
    /// Product's description.
    /// </summary>
    [Length(10, 2000, ErrorMessage = "Description's length must be within range from 10 to 2000 symbols.")]
    required public string Description { get; set; }

    /// <summary>
    /// Product's price.
    /// </summary>
    [Range(0.0, double.MaxValue, ErrorMessage = "Price can't be negative.")]
    required public decimal Price { get; set; }

    /// <summary>
    /// Brand's id.
    /// </summary>
    required public int BrandId { get; set; }

    /// <summary>
    /// Category's id.
    /// </summary>
    required public int CategoryId { get; set; }

    /// <summary>
    /// Paths to product's images.
    /// </summary>
    required public ICollection<string> ImagesPaths { get; set; }
}
