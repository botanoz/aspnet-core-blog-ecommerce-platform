

using System.Linq.Expressions;

namespace BusinessLayer.Services.GenericServices;

/// <summary>
/// Generic service interface defining basic CRUD operations.
/// </summary>
/// <typeparam name="TEntity">The type of the entity.</typeparam>
public interface IGenericService<TEntity> where TEntity : class
{
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task<TEntity> GetByIdAsync(object id);
    Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate);
    Task AddAsync(TEntity entity);
    Task AddRangeAsync(IEnumerable<TEntity> entities);
    void Update(TEntity entity);
    void Remove(TEntity entity);
    void RemoveRange(IEnumerable<TEntity> entities);
}