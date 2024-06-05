
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Model;

/// <summary>
/// Cart class representing the Cart entity.
/// </summary>
public class Cart : BaseModel
{
    [Required]
    public string UserId { get; set; }

    [ForeignKey("UserId")]
    public ApplicationUser User { get; set; }

    public ICollection<CartDetail> CartDetails { get; set; }
}