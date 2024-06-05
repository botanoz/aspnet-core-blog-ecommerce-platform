
using BusinessLayer.Services.GenericServices;
using BusinessLayer.Services.SipecificServices.Interface;
using BusinessLayer.Services.UnitOfWork;
using DataLayer.Model;

namespace BusinessLayer.Services.SipecificServices.Class;

/// <summary>
/// Partner service implementation providing specific operations for Partner.
/// </summary>
public class PartnerService : GenericService<Partner>, IPartnerService
{
    public PartnerService(IUnitOfWork unitOfWork) : base(unitOfWork.Partners, unitOfWork)
    {
    }
}
