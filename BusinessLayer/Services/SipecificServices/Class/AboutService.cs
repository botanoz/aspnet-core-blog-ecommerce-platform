
using BusinessLayer.Services.GenericServices;
using BusinessLayer.Services.SipecificServices.Interface;
using BusinessLayer.Services.UnitOfWork;
using DataLayer.Model;

namespace BusinessLayer.Services.SipecificServices.Class;

/// <summary>
/// About service implementation providing specific operations for About.
/// </summary>
public class AboutService : GenericService<About>, IAboutService
{
    public AboutService(IUnitOfWork unitOfWork) : base(unitOfWork.Abouts, unitOfWork)
    {
    }
}
