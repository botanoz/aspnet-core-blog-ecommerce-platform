
using BusinessLayer.Services.GenericServices;
using BusinessLayer.Services.SipecificServices.Interface;
using BusinessLayer.Services.UnitOfWork;
using DataLayer.Model;

namespace BusinessLayer.Services.SipecificServices.Class;

/// <summary>
/// User service implementation providing specific operations for ApplicationUser.
/// </summary>
public class UserService : GenericService<ApplicationUser>, IUserService
{
    private readonly IUnitOfWork _unitOfWork;

    public UserService(IUnitOfWork unitOfWork) : base(unitOfWork.Users, unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<ApplicationUser> GetUserByEmailAsync(string email)
    {
        return await _unitOfWork.Users.GetUserByEmailAsync(email);
    }
}
