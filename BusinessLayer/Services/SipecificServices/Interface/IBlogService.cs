using BusinessLayer.Services.GenericServices;
using BusinessLayer.Services.ViewModel;
using DataLayer.Model;

namespace BusinessLayer.Services.SipecificServices.Interface;

/// <summary>
/// Blog service interface defining additional operations specific to Blog.
/// </summary>
public interface IBlogService : IGenericService<Blog>
{
    Task<Blog> GetBlogByTitleAsync(string title);
    Task<IEnumerable<BlogViewModel>> GetBlogDataListAsync();
}