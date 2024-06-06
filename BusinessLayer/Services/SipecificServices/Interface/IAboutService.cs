
using BusinessLayer.Services.GenericServices;
using BusinessLayer.Services.ViewModel;
using DataLayer.Model;

namespace BusinessLayer.Services.SipecificServices.Interface;

/// <summary>
/// About service interface defining additional operations specific to About.
/// </summary>
public interface IAboutService : IGenericService<About>
{
    Task<AboutViewModel> GetAboutPageDataAsync();
    Task<string> GetDescriptionByNameAsync(string name);
}
