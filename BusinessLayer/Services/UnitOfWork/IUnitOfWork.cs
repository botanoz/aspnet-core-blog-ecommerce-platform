using System;
using System.Threading.Tasks;
using DataLayer.Model;
using DataLayer.Repository.GenericRepository;
using DataLayer.Repository.SpecificRepository.Interface;

namespace BusinessLayer.Services.UnitOfWork;

/// <summary>
/// Unit of work interface defining repositories and commit operation.
/// </summary>
public interface IUnitOfWork : IDisposable
{
    IAboutRepository Abouts { get; }
    IBlogRepository Blogs { get; }
    ICartRepository Carts { get; }
    ICartDetailRepository CartDetails { get; }
    IClientSayRepository ClientSays { get; }
    INewsRepository News { get; }
    IOrderRepository Orders { get; }
    IOrderDetailRepository OrderDetails { get; }
    IPartnerRepository Partners { get; }
    IPortfolioRepository Portfolios { get; }
    IProductRepository Products { get; }
    ISettingRepository Settings { get; }
    IUserRepository Users { get; }
    Task<int> CompleteAsync();
}
