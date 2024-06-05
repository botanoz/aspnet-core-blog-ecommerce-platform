using System.ComponentModel.DataAnnotations;
namespace DataLayer.Model;

/// <summary>
/// BaseModel class includes common properties for all entities.
/// </summary>
public abstract class BaseModel
{
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// Date when the record was created.
    /// </summary>
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Date when the record was last updated.
    /// </summary>
    public DateTime? UpdatedDate { get; set; }

    /// <summary>
    /// Date when the record was deleted.
    /// </summary>
    public DateTime? DeletedDate { get; set; }

    /// <summary>
    /// Indicates if the record is active.
    /// </summary>
    public bool IsActive { get; set; } = true;
}