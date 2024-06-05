using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Entity;
using DataLayer.Model;
using DataLayer.Repository.GenericRepository;
using DataLayer.Repository.SpecificRepository.Interface;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Repository.SpecificRepository.Class
{
    public class BlogRepository : GenericRepository<Blog>, IBlogRepository
    {
        private readonly ApplicationDbContext _context;

        public BlogRepository(ApplicationDbContext context) : base(context)
        {
            _context=context;
        }

        public async Task<IEnumerable<Blog>> GetBlogsByUserId(string userId)
        {
            return await _context.Blogs.Where(b => b.UserId == userId).ToListAsync();
        }

        public async Task<IEnumerable<Blog>> GetRecentBlogs(int count)
        {
            return await _context.Blogs.OrderByDescending(b => b.Date).Take(count).ToListAsync();
        }
    }
}
