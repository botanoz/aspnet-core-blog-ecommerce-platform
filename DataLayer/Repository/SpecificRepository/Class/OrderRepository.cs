
using DataLayer.Model;
using DataLayer.Repository.GenericRepository;
using DataLayer.Repository.SpecificRepository.Interface;
using DataLayer.Entity;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Repository.SpecificRepository.Class;

public class OrderRepository : GenericRepository<Order>, IOrderRepository
{
    public OrderRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Order>> GetAllPendingOrders()
    {
        return await _context.Orders.Where(o => o.Status == OrderStatus.Pending).ToListAsync();
    }
}