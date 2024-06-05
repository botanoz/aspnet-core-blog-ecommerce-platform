using BusinessLayer.Services.GenericServices;
using BusinessLayer.Services.SipecificServices.Interface;
using BusinessLayer.Services.UnitOfWork;
using DataLayer.Model;
using DataLayer.Repository.GenericRepository;

namespace BusinessLayer.Services.SipecificServices.Class;

/// <summary>
/// Portfolio service implementation providing specific operations for Portfolio.
/// </summary>
public class PortfolioService : GenericService<Portfolio>, IPortfolioService
{
    private readonly IUnitOfWork _unitOfWork;

    public PortfolioService(IUnitOfWork unitOfWork) : base(unitOfWork.Portfolios, unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Portfolio> GetPortfolioByTitleAsync(string title)
    {
        return await _unitOfWork.Portfolios.FirstOrDefaultAsync(p => p.Title == title);
    }
}