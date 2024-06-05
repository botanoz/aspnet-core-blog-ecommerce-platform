using System.ComponentModel.DataAnnotations;


namespace DataLayer.Model;

/// <summary>
/// Setting class representing the Setting entity.
/// </summary>
/// <summary>
/// Setting class representing the Setting entity.
/// </summary>
public class Setting
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(255)]
    public string Key { get; set; }

    [Required]
    [StringLength(255)]
    public string Value { get; set; }
}