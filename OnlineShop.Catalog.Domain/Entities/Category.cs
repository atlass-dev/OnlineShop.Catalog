namespace OnlineShop.Catalog.Domain.Entities;

/// <summary>
/// Product's category.
/// </summary>
public class Category
{
    /// <summary>
    /// Category Id.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Category name.
    /// </summary>
    required public string Name { get; set; }

    /// <summary>
    /// Category description.
    /// </summary>
    required public string Description { get; set; }
}
