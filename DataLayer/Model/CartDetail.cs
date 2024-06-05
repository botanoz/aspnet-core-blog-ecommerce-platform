
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Model;

/// <summary>
/// CartDetail class representing the CartDetail entity.
/// </summary>
public class CartDetail : BaseModel
{
    [Required]
    public int CartId { get; set; }

    [ForeignKey("CartId")]
    public Cart Cart { get; set; }

    [Required]
    public int ProductId { get; set; }

    [ForeignKey("ProductId")]
    public Product Product { get; set; }

    [Required]
    public int Quantity { get; set; }

    /// <summary>
    /// Unit price is always taken from the current product price.
    /// </summary>
    public decimal UnitPrice => Product.Price;

    /// <summary>
    /// Total price is calculated.
    /// </summary>
    public decimal TotalPrice => Quantity * Product.Price;
}