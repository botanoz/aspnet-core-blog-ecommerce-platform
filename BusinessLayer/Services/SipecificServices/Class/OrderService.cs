
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
    public OrderService(IUnitOfWork unitOfWork) : base(unitOfWork.Orders, unitOfWork)
    {
    }
}
