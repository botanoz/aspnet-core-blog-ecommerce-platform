
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;


namespace BusinessLayer.Services.ViewModel;

public class BlogViewModel
{
    public int Id { get; set; }
    [Required]
    public DateTime Date { get; set; }
    [Required]
    [StringLength(255)]
    public string Title { get; set; }
    [Required]
    [StringLength(2000)]
    public string Description { get; set; }
    [Required]
    public string UserId { get; set; }
    public IFormFile Thumbnail { get; set; }
    public string ThumbnailPath { get; set; }
}
