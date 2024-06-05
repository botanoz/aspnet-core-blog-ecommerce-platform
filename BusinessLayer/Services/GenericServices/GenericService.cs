using BusinessLayer.Services.UnitOfWork;
using DataLayer.Repository.GenericRepository;
using System.Linq.Expressions;

namespace BusinessLayer.Services.GenericServices;

/// <summary>
/// Generic service implementation providing basic CRUD operations.
/// </summary>
/// <typeparam name="TEntity">The type of the entity.</typeparam>
public class GenericService<TEntity> : IGenericService<TEntity> where TEntity : class
{
    private readonly IGenericRepository<TEntity> _repository;
    private readonly IUnitOfWork _unitOfWork;

    /// <summary>
    /// Initializes a new instance of the <see cref="GenericService{TEntity}"/> class.
    /// </summary>
    /// <param name="repository">The generic repository.</param>
    /// <param name="unitOfWork">The unit of work.</param>
    public GenericService(IGenericRepository<TEntity> repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<TEntity> GetByIdAsync(object id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
    {
        return await _repository.FindAsync(predicate);
    }

    public async Task AddAsync(TEntity entity)
    {
        await _repository.AddAsync(entity);
        await _unitOfWork.CompleteAsync();
    }

    public async Task AddRangeAsync(IEnumerable<TEntity> entities)
    {
        await _repository.AddRangeAsync(entities);
        await _unitOfWork.CompleteAsync();
    }

    public void Update(TEntity entity)
    {
        _repository.Update(entity);
        _unitOfWork.CompleteAsync();
    }

    public void Remove(TEntity entity)
    {
        _repository.Remove(entity);
        _unitOfWork.CompleteAsync();
    }

    public void RemoveRange(IEnumerable<TEntity> entities)
    {
        _repository.RemoveRange(entities);
        _unitOfWork.CompleteAsync();
    }
}