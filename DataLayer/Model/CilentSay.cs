using System.ComponentModel.DataAnnotations;
namespace DataLayer.Model;

/// <summary>
/// ClientSay class representing the ClientSay entity.
/// </summary>
public class ClientSay : BaseModel
{
    [Required]
    [StringLength(255)]
    public string FullName { get; set; }

    [Required]
    [StringLength(255)]
    public string Company { get; set; }

    [Required]
    [StringLength(2000)]
    public string Comment { get; set; }

    [Required]
    [StringLength(2083)]
    public string Image { get; set; }
}
