
using BusinessLayer.Services.GenericServices;
using DataLayer.Model;

namespace BusinessLayer.Services.SipecificServices.Interface;

/// <summary>
/// Order service interface defining additional operations specific to Order.
/// </summary>
public interface IOrderService : IGenericService<Order>
{
    Task<IEnumerable<Order>> GetAllPendingOrders();
    Task<int> GetCountOrders(OrderStatus orderStatus);
}
