
using BusinessLayer.Services.GenericServices;
using DataLayer.Model;

namespace BusinessLayer.Services.SipecificServices.Interface;

/// <summary>
/// User service interface defining additional operations specific to ApplicationUser.
/// </summary>
public interface IUserService : IGenericService<ApplicationUser>
{
    Task<ApplicationUser> GetUserByEmailAsync(string email);
}