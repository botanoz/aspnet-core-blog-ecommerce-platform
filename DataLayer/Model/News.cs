using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Model;

/// <summary>
/// News class representing the News entity.
/// </summary>
public class News : BaseModel
{
    [Required]
    [StringLength(255)]
    public string Title { get; set; }

    [Required]
    [StringLength(2000)]
    public string Description { get; set; }

    [Required]
    [StringLength(2083)]
    public string Image { get; set; }

    public string UserId { get; set; }

    [ForeignKey("UserId")]
    public ApplicationUser User { get; set; }
}
