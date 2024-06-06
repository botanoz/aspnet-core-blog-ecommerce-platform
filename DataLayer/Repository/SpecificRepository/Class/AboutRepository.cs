
using DataLayer.Entity;
using DataLayer.Model;
using DataLayer.Repository.GenericRepository;
using DataLayer.Repository.SpecificRepository.Interface;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Repository.SpecificRepository.Class;

public class AboutRepository : GenericRepository<About>, IAboutRepository
{
    public AboutRepository(ApplicationDbContext context) : base(context)
    {
    }
    public async Task<string> GetDescriptionByNameAsync(string name)
    {
        var about = await _context.Abouts.FirstOrDefaultAsync(a => a.Name == name);
        return about?.Description;
    }
}