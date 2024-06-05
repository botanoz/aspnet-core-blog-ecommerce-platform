
using DataLayer.Entity;
using DataLayer.Model;
using DataLayer.Repository.GenericRepository;
using DataLayer.Repository.SpecificRepository.Interface;

namespace DataLayer.Repository.SpecificRepository.Class;

public class AboutRepository : GenericRepository<About>, IAboutRepository
{
    public AboutRepository(ApplicationDbContext context) : base(context)
    {
    }
}