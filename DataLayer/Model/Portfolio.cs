using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataLayer.Model;

/// <summary>
/// Portfolio class representing the Portfolio entity.
/// </summary>
public class Portfolio : BaseModel
{
    [Required]
    [StringLength(255)]
    public string Client { get; set; }

    [Required]
    [StringLength(2083)]
    public string ProjectUrl { get; set; }

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
