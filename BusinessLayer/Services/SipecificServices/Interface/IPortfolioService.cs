

using BusinessLayer.Services.GenericServices;
using BusinessLayer.Services.ViewModel;
using DataLayer.Model;

namespace BusinessLayer.Services.SipecificServices.Interface;

/// <summary>
/// Portfolio service interface defining additional operations specific to Portfolio.
/// </summary>
public interface IPortfolioService : IGenericService<Portfolio>
{
    Task<Portfolio> GetPortfolioByTitleAsync(string title);
    Task<IEnumerable<ListViewModel>> GetPortfolioDataListAsync();
}