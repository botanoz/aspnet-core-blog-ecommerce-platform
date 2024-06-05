using System.ComponentModel.DataAnnotations;


namespace DataLayer.Model;

/// <summary>
/// About class representing the About entity.
/// </summary>
public class About : BaseModel
{
    [Required]
    [StringLength(500)]
    public string Description { get; set; }

    [Required]
    public string Name { get; set; }
}

