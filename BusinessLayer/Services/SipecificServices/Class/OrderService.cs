
using BusinessLayer.Services.GenericServices;
using BusinessLayer.Services.SipecificServices.Interface;
using BusinessLayer.Services.UnitOfWork;
using DataLayer.Model;

namespace BusinessLayer.Services.SipecificServices.Class;

/// <summary>
/// Order service implementation providing specific operations for Order.
/// </summary>
public class OrderService : GenericService<Order>, IOrderService
{
    private readonly IUnitOfWork _unitOfWork;

    public OrderService(IUnitOfWork unitOfWork) : base(unitOfWork.Orders, unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<Order>> GetAllPendingOrders()
    {
        return await _unitOfWork.Orders.GetAllPendingOrders();
                               
    }

    public async Task<int> GetCountOrders(OrderStatus orderStatus)
    {
        var OrderList = await _unitOfWork.Orders.GetAllAsync();
        return  OrderList.Where(x => x.Status == orderStatus).Count();
    }
}
