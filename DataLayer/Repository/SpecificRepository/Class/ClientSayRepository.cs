
using DataLayer.Model;
using DataLayer.Repository.GenericRepository;
using DataLayer.Repository.SpecificRepository.Interface;
using DataLayer.Entity;
namespace DataLayer.Repository.SpecificRepository.Class;

public class ClientSayRepository : GenericRepository<ClientSay>, IClientSayRepository
{
    public ClientSayRepository(ApplicationDbContext context) : base(context)
    {
    }
}