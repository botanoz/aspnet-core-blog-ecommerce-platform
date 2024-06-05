
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;


namespace DataLayer.Model;

/// <summary>
/// ApplicationUser class extends IdentityUser to include additional properties.
/// </summary>
public class ApplicationUser : IdentityUser
{
    [Required]
    [StringLength(255)]
    public string FirstName { get; set; }

    [Required]
    [StringLength(255)]
    public string LastName { get; set; }

    [StringLength(2083)]
    public string ProfilePicture { get; set; }

    public string FullName => $"{FirstName} {LastName}";

    public ICollection<Blog> Blogs { get; set; }
    public ICollection<Portfolio> Portfolios { get; set; }
    public ICollection<Order> Orders { get; set; }
    public ICollection<Cart> Carts { get; set; }
}