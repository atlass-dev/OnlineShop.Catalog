namespace OnlineShop.Catalog.Domain.Entities;

/// <summary>
/// Product.
/// </summary>
public class Product
{
    /// <summary>
    /// Product's id.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Product's name.
    /// </summary>
    required public string Name { get; set; }

    /// <summary>
    /// Product's description.
    /// </summary>
    required public string Description { get; set; }

    /// <summary>
    /// Product's price.
    /// </summary>
    required public decimal Price { get; set; }

    /// <summary>
    /// Brand id.
    /// </summary>
    required public int BrandId { get; set; }

    /// <summary>
    /// Product's brand.
    /// </summary>
    required public Brand Brand { get; set; }

    /// <summary>
    /// Category id.
    /// </summary>
    required public int CategoryId { get; set; }

    /// <summary>
    /// Product's category.
    /// </summary>
    required public Category Category { get; set; }

    /// <summary>
    /// Product images.
    /// </summary>
    public ICollection<ProductImage> Images { get; set; } = new List<ProductImage>();
}
