
using BusinessLayer.Services.GenericServices;
using BusinessLayer.Services.SipecificServices.Interface;
using BusinessLayer.Services.UnitOfWork;
using DataLayer.Model;

namespace BusinessLayer.Services.SipecificServices.Class;

/// <summary>
/// Cart service implementation providing specific operations for Cart.
/// </summary>
public class CartService : GenericService<Cart>, ICartService
{
    public CartService(IUnitOfWork unitOfWork) : base(unitOfWork.Carts, unitOfWork)
    {
    }
}