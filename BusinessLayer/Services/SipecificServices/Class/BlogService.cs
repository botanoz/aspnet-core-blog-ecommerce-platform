
using BusinessLayer.Services.GenericServices;
using BusinessLayer.Services.SipecificServices.Interface;
using BusinessLayer.Services.UnitOfWork;
using DataLayer.Model;

namespace BusinessLayer.Services.SipecificServices.Class;

/// <summary>
/// Blog service implementation providing specific operations for Blog.
/// </summary>
public class BlogService : GenericService<Blog>, IBlogService
{
    private readonly IUnitOfWork _unitOfWork;

    public BlogService(IUnitOfWork unitOfWork) : base(unitOfWork.Blogs, unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    /// <summary>
    /// Gets a blog by its title.
    /// </summary>
    /// <param name="title">The title of the blog.</param>
    /// <returns>The blog with the specified title, if found.</returns>
    public async Task<Blog> GetBlogByTitleAsync(string title)
    {
        return await _unitOfWork.Blogs.FirstOrDefaultAsync(b => b.Title == title);
    }
}
