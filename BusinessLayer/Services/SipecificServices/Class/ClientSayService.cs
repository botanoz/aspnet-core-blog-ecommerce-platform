
using BusinessLayer.Services.GenericServices;
using BusinessLayer.Services.SipecificServices.Interface;
using BusinessLayer.Services.UnitOfWork;
using DataLayer.Model;

namespace BusinessLayer.Services.SipecificServices.Class;

/// <summary>
/// ClientSay service implementation providing specific operations for ClientSay.
/// </summary>
public class ClientSayService : GenericService<ClientSay>, IClientSayService
{
    public ClientSayService(IUnitOfWork unitOfWork) : base(unitOfWork.ClientSays, unitOfWork)
    {
    }
}
