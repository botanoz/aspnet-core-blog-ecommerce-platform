using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Model;

/// <summary>
/// Blog class representing the Blog entity.
/// </summary>
public class Blog : BaseModel
{
    [Required]
    public DateTime Date { get; set; }

    [Required]
    [StringLength(2083)]
    public string ThumbnailPath { get; set; }

    [Required]
    [StringLength(255)]
    public string Title { get; set; }

    [Required]
    [StringLength(2000)]
    public string Description { get; set; }

    [Required]
    public string UserId { get; set; }

    [ForeignKey("UserId")]
    public ApplicationUser User { get; set; }
}
