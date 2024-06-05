
using DataLayer.Model;
using DataLayer.Repository.GenericRepository;
using DataLayer.Repository.SpecificRepository.Interface;
using DataLayer.Entity;
namespace DataLayer.Repository.SpecificRepository.Class;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(ApplicationDbContext context) : base(context)
    {
    }
}