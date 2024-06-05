using System.ComponentModel.DataAnnotations;


namespace DataLayer.Model;

/// <summary>
/// Product class representing the Product entity.
/// </summary>
public class Product : BaseModel
{
    [Required]
    [StringLength(255)]
    public string Name { get; set; }

    [StringLength(500)]
    public string Description { get; set; }

    [Required]
    public decimal Price { get; set; }

    [StringLength(2083)]
    public string ImageUrl { get; set; }

    public ICollection<OrderDetail> OrderDetails { get; set; }
    public ICollection<CartDetail> CartDetails { get; set; }
}