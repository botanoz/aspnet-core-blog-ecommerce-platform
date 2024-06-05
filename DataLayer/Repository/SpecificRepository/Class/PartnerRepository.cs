
using DataLayer.Model;
using DataLayer.Repository.GenericRepository;
using DataLayer.Repository.SpecificRepository.Interface;
using DataLayer.Entity;
namespace DataLayer.Repository.SpecificRepository.Class;

public class PartnerRepository : GenericRepository<Partner>, IPartnerRepository
{
    public PartnerRepository(ApplicationDbContext context) : base(context)
    {
    }
}
