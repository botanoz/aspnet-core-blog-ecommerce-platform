
using DataLayer.Model;
using DataLayer.Repository.GenericRepository;

namespace DataLayer.Repository.SpecificRepository.Interface;

// <summary>
/// User repository interface defining additional operations specific to ApplicationUser.
/// </summary>
public interface IUserRepository : IGenericRepository<ApplicationUser>
{
    Task<ApplicationUser> GetUserByEmailAsync(string email);
}
