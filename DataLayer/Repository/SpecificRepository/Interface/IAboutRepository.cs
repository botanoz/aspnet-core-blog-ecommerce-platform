
using DataLayer.Model;
using DataLayer.Repository.GenericRepository;

namespace DataLayer.Repository.SpecificRepository.Interface;

public interface IAboutRepository : IGenericRepository<About>
{
    Task<string> GetDescriptionByNameAsync(string name);
}