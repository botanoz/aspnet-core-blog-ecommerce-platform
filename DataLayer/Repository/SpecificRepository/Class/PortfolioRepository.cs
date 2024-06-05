
using DataLayer.Model;
using DataLayer.Repository.GenericRepository;
using DataLayer.Repository.SpecificRepository.Interface;
using DataLayer.Entity;
namespace DataLayer.Repository.SpecificRepository.Class;

public class PortfolioRepository : GenericRepository<Portfolio>, IPortfolioRepository
{
    public PortfolioRepository(ApplicationDbContext context) : base(context)
    {
    }
}