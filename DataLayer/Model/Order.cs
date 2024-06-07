using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataLayer.Model;

/// <summary>
/// Order class representing the Order entity.
/// </summary>
public class Order : BaseModel
{
    [Required]
    public string UserId { get; set; }

    [ForeignKey("UserId")]
    public ApplicationUser User { get; set; }

    [Required]
    public DateTime OrderDate { get; set; }

    [Required]
    public decimal TotalAmount { get; set; }

    public OrderStatus Status { get; set; } = OrderStatus.Pending;
    public ICollection<OrderDetail> OrderDetails { get; set; }
}
/// <summary>
/// Enumeration representing the possible statuses of an order.
/// </summary>
public enum OrderStatus
{
    Pending,
    Processing,
    Shipped,
    Delivered,
    Canceled
}