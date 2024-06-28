using System.Threading.Tasks;
using DataLayer.Model;
using DataLayer.Repository.GenericRepository;
using DataLayer.Repository.SpecificRepository.Class;
using DataLayer.Repository.SpecificRepository.Interface;
using DataLayer.Entity;
namespace BusinessLayer.Services.UnitOfWork;

/// <summary>
/// Unit of work implementation encapsulating repositories and managing transactions.
/// </summary>
public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _context;
    private readonly Dictionary<Type, object> _repositories;
    /// <summary>
    /// Initializes a new instance of the <see cref="UnitOfWork"/> class.
    /// </summary>
    /// <param name="context">The database context.</param>
    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
        Abouts = new AboutRepository(_context);
        Blogs = new BlogRepository(_context);
        Carts = new CartRepository(_context);
        CartDetails = new CartDetailRepository(_context);
        ClientSays = new ClientSayRepository(_context);
        News = new NewsRepository(_context);
        Orders = new OrderRepository(_context);
        OrderDetails = new OrderDetailRepository(_context);
        Partners = new PartnerRepository(_context);
        Portfolios = new PortfolioRepository(_context);
        Products = new ProductRepository(_context);
        Settings = new SettingRepository(_context);
        Users = new UserRepository(_context);
        _repositories = new Dictionary<Type, object>();
    }

    public IAboutRepository Abouts { get; private set; }
    public IBlogRepository Blogs { get; private set; }
    public ICartRepository Carts { get; private set; }
    public ICartDetailRepository CartDetails { get; private set; }
    public IClientSayRepository ClientSays { get; private set; }
    public INewsRepository News { get; private set; }
    public IOrderRepository Orders { get; private set; }
    public IOrderDetailRepository OrderDetails { get; private set; }
    public IPartnerRepository Partners { get; private set; }
    public IPortfolioRepository Portfolios { get; private set; }
    public IProductRepository Products { get; private set; }
    public ISettingRepository Settings { get; private set; }
    public IUserRepository Users { get; private set; }


    /// <summary>
    /// Saves all changes made in this context to the database.
    /// </summary>
    /// <returns>The number of state entries written to the database.</returns>
    public async Task<int> CompleteAsync()
    {
        return await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Disposes the context.
    /// </summary>
    public void Dispose()
    {
        _context.Dispose();
    }

    public IGenericRepository<T> GetRepository<T>() where T : class
    {
        if (_repositories.ContainsKey(typeof(T)))
        {
            return (IGenericRepository<T>)_repositories[typeof(T)];
        }

        var repository = new GenericRepository<T>(_context);
        _repositories[typeof(T)] = repository;
        return repository;
    }
}