
using DataLayer.Model;
using DataLayer.Repository.GenericRepository;
using DataLayer.Repository.SpecificRepository.Interface;
using DataLayer.Entity;
namespace DataLayer.Repository.SpecificRepository.Class;

public class CartRepository : GenericRepository<Cart>, ICartRepository
{
    public CartRepository(ApplicationDbContext context) : base(context)
    {
    }
}