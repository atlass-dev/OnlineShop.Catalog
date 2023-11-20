namespace OnlineShop.Catalog.UseCases.Products.Queries.GetProductById;

/// <summary>
/// Product image DTO.
/// </summary>
public class ProductImageDto
{
    /// <summary>
    /// Product image id.
    /// </summary>
    public int Id { get; init; }

    /// <summary>
    /// Product image url.
    /// </summary>
    required public string Url { get; init; }
}
