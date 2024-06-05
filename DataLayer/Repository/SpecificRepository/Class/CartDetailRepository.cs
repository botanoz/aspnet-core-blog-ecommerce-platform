
using DataLayer.Model;
using DataLayer.Repository.GenericRepository;
using DataLayer.Repository.SpecificRepository.Interface;
using DataLayer.Entity;
namespace DataLayer.Repository.SpecificRepository.Class;

public class CartDetailRepository : GenericRepository<CartDetail>, ICartDetailRepository
{
    public CartDetailRepository(ApplicationDbContext context) : base(context)
    {
    }
}
