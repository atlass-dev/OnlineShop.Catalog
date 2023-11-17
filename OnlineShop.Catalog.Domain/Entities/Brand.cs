namespace OnlineShop.Catalog.Domain.Entities;

/// <summary>
/// Product's creator.
/// </summary>
public class Brand
{
    /// <summary>
    /// Brand's id.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Brand's name.
    /// </summary>
    required public string Name { get; set; }

    /// <summary>
    /// Brand's description.
    /// </summary>
    required public string Description { get; set; }

    /// <summary>
    /// Brand's images.
    /// </summary>
    public ICollection<BrandImage> Images { get; set; } = new List<BrandImage>();
}
