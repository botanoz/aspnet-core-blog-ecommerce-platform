
using BusinessLayer.Services.GenericServices;
using BusinessLayer.Services.SipecificServices.Interface;
using BusinessLayer.Services.UnitOfWork;
using DataLayer.Model;

namespace BusinessLayer.Services.SipecificServices.Class;

/// <summary>
/// OrderDetail service implementation providing specific operations for OrderDetail.
/// </summary>
public class OrderDetailService : GenericService<OrderDetail>, IOrderDetailService
{
    public OrderDetailService(IUnitOfWork unitOfWork) : base(unitOfWork.OrderDetails, unitOfWork)
    {
    }
}