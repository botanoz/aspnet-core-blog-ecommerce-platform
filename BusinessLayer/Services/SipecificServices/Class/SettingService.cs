
using BusinessLayer.Services.GenericServices;
using BusinessLayer.Services.SipecificServices.Interface;
using BusinessLayer.Services.UnitOfWork;
using DataLayer.Model;

namespace BusinessLayer.Services.SipecificServices.Class;

/// <summary>
/// Setting service implementation providing specific operations for Setting.
/// </summary>
public class SettingService : GenericService<Setting>, ISettingService
{
    public SettingService(IUnitOfWork unitOfWork) : base(unitOfWork.Settings, unitOfWork)
    {
    }
}
