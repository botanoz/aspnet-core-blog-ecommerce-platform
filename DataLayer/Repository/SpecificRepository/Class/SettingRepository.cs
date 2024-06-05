
using DataLayer.Model;
using DataLayer.Repository.GenericRepository;
using DataLayer.Repository.SpecificRepository.Interface;
using DataLayer.Entity;
namespace DataLayer.Repository.SpecificRepository.Class;

public class SettingRepository : GenericRepository<Setting>, ISettingRepository
{
    public SettingRepository(ApplicationDbContext context) : base(context)
    {
    }
}