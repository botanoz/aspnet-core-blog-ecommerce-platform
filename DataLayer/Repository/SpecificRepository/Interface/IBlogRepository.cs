using System.Collections.Generic;
using System.Threading.Tasks;
using DataLayer.Model;
using DataLayer.Repository.GenericRepository;

namespace DataLayer.Repository.SpecificRepository.Interface
{
    public interface IBlogRepository : IGenericRepository<Blog>
    {
        Task<IEnumerable<Blog>> GetBlogsByUserId(string userId);
        Task<IEnumerable<Blog>> GetRecentBlogs(int count);
    }
}
