
using BusinessLayer.Services.GenericServices;
using BusinessLayer.Services.SipecificServices.Interface;
using BusinessLayer.Services.UnitOfWork;
using DataLayer.Model;

namespace BusinessLayer.Services.SipecificServices.Class;

/// <summary>
/// News service implementation providing specific operations for News.
/// </summary>
public class NewsService : GenericService<News>, INewsService
{
    public NewsService(IUnitOfWork unitOfWork) : base(unitOfWork.News, unitOfWork)
    {
    }
}
