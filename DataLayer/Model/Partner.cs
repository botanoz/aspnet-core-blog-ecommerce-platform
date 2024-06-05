using System.ComponentModel.DataAnnotations;


namespace DataLayer.Model;

/// <summary>
/// Partner class representing the Partner entity.
/// </summary>
public class Partner : BaseModel
{
    [Required]
    [StringLength(255)]
    public string Name { get; set; }

    [Required]
    [StringLength(2083)]
    public string Image { get; set; }
}