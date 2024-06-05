
using DataLayer.Model;
using DataLayer.Repository.GenericRepository;
using DataLayer.Repository.SpecificRepository.Interface;
using Microsoft.EntityFrameworkCore;
using DataLayer.Entity;
namespace DataLayer.Repository.SpecificRepository.Class;

/// <summary>
/// User repository implementation providing specific operations for ApplicationUser.
/// </summary>
public class UserRepository : GenericRepository<ApplicationUser>, IUserRepository
{
    public UserRepository(ApplicationDbContext context) : base(context)
    {
    }

    /// <summary>
    /// Gets a user by their email address.
    /// </summary>
    /// <param name="email">The email address of the user.</param>
    /// <returns>The user with the specified email address, if found.</returns>
    public async Task<ApplicationUser> GetUserByEmailAsync(string email)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
    }
}