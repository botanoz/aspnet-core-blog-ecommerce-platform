using BusinessLayer.Services.GenericServices;
using BusinessLayer.Services.SipecificServices.Interface;
using BusinessLayer.Services.UnitOfWork;
using BusinessLayer.Services.ViewModel;
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
    public async Task<IEnumerable<ListViewModel>> GetPortfolioDataListAsync()
    {
        var users = await _unitOfWork.Users.GetAllAsync();
        var portfolios = await _unitOfWork.Portfolios.GetAllAsync();



        var portfolioViewModels = portfolios.Join(
            users,
            portfolio => portfolio.UserId,
            user => user.Id,
            (portfolio, user) => new ListViewModel
            {
                Id = portfolio.Id,
                Title = portfolio.Title,
                CreatedDate = portfolio.CreatedDate,
                FullName = user.FullName,
                UserPictureUrl = !string.IsNullOrEmpty(user.ProfilePicture) ? user.ProfilePicture : "~/dist/img/avatar.png"
            }).ToList();

        return portfolioViewModels;

    }
}