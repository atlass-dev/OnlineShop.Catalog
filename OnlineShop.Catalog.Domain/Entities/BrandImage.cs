namespace OnlineShop.Catalog.Domain.Entities;

/// <summary>
/// Image.
/// </summary>
public class BrandImage
{
    /// <summary>
    /// Image's id.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Brand id.
    /// </summary>
    required public int BrandId { get; set; }

    /// <summary>
    /// Image's URL.
    /// </summary>
    required public string Url { get; set; }
}
