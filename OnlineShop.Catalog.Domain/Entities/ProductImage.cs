namespace OnlineShop.Catalog.Domain.Entities;

/// <summary>
/// Product's image.
/// </summary>
public class ProductImage
{
    /// <summary>
    /// Id.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Product id.
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Image's URL.
    /// </summary>
    required public string Url { get; set; }
}
