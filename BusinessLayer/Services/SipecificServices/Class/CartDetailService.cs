
using BusinessLayer.Services.GenericServices;
using BusinessLayer.Services.SipecificServices.Interface;
using BusinessLayer.Services.UnitOfWork;
using DataLayer.Model;

namespace BusinessLayer.Services.SipecificServices.Class
{
    /// <summary>
    /// CartDetail service implementation providing specific operations for CartDetail.
    /// </summary>
    public class CartDetailService : GenericService<CartDetail>, ICartDetailService
    {
        public CartDetailService(IUnitOfWork unitOfWork) : base(unitOfWork.CartDetails, unitOfWork)
        {
        }
    }
}
