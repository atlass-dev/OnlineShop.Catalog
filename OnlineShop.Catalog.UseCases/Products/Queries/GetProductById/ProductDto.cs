namespace OnlineShop.Catalog.UseCases.Products.Queries.GetProductById;

/// <summary>
/// Product DTO.
/// </summary>
public class ProductDto
{
    /// <summary>
    /// Product's id.
    /// </summary>
    public int Id { get; init; }

    /// <summary>
    /// Product's name.
    /// </summary>
    required public string Name { get; init; }

    /// <summary>
    /// Product's description.
    /// </summary>
    required public string Description { get; init; }

    /// <summary>
    /// Product's price.
    /// </summary>
    required public decimal Price { get; init; }

    /// <summary>
    /// Product's brand.
    /// </summary>
    required public string Brand { get; init; }

    /// <summary>
    /// Product's category.
    /// </summary>
    required public string Category { get; init; }

    /// <summary>
    /// Paths to product's images.
    /// </summary>
    public ICollection<ProductImageDto> Images { get; init; } = new List<ProductImageDto>();
}
