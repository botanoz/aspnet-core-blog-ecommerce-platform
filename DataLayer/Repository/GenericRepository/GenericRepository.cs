using DataLayer.Entity;
using DataLayer.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataLayer.Repository.GenericRepository;

/// <summary>
/// Generic repository implementation providing basic CRUD operations.
/// </summary>
/// <typeparam name="TEntity">The type of the entity.</typeparam>
public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
{
    protected readonly ApplicationDbContext _context;
    private readonly DbSet<TEntity> _dbSet;

    /// <summary>
    /// Initializes a new instance of the <see cref="GenericRepository{TEntity}"/> class.
    /// </summary>
    /// <param name="context">The database context.</param>
    public GenericRepository(ApplicationDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<TEntity>();
    }

    /// <summary>
    /// Gets all entities.
    /// </summary>
    /// <returns>A list of all entities.</returns>
    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    /// <summary>
    /// Gets an entity by its identifier.
    /// </summary>
    /// <param name="id">The identifier of the entity.</param>
    /// <returns>The entity if found; otherwise, null.</returns>
    public async Task<TEntity> GetByIdAsync(object id)
    {
        return await _dbSet.FindAsync(id);
    }
    /// <summary>
    /// Finds the first entity that matches the specified predicate.
    /// </summary>
    /// <param name="predicate">The predicate to filter entities.</param>
    /// <returns>The first matching entity, if found.</returns>
    public async Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
    {
        return await _dbSet.FirstOrDefaultAsync(predicate);
    }

    /// <summary>
    /// Finds entities based on the specified predicate.
    /// </summary>
    /// <param name="predicate">The predicate to filter entities.</param>
    /// <returns>A list of matching entities.</returns>
    public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
    {
        return await _dbSet.Where(predicate).ToListAsync();
    }

    /// <summary>
    /// Adds a new entity to the database.
    /// </summary>
    /// <param name="entity">The entity to add.</param>
    public async Task AddAsync(TEntity entity)
    {
        await _dbSet.AddAsync(entity);
    }

    /// <summary>
    /// Adds multiple new entities to the database.
    /// </summary>
    /// <param name="entities">The entities to add.</param>
    public async Task AddRangeAsync(IEnumerable<TEntity> entities)
    {
        await _dbSet.AddRangeAsync(entities);
    }

    /// <summary>
    /// Updates an existing entity in the database.
    /// </summary>
    /// <param name="entity">The entity to update.</param>
    public void Update(TEntity entity)
    {
        _dbSet.Update(entity);
    }

    /// <summary>
    /// Removes an entity from the database.
    /// </summary>
    /// <param name="entity">The entity to remove.</param>
    public void Remove(TEntity entity)
    {
        _dbSet.Remove(entity);
    }

    /// <summary>
    /// Removes multiple entities from the database.
    /// </summary>
    /// <param name="entities">The entities to remove.</param>
    public void RemoveRange(IEnumerable<TEntity> entities)
    {
        _dbSet.RemoveRange(entities);
    }
}