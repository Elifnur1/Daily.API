using System;

namespace Elif.Data.Abstract;

public interface IGenericRepository<TEntity> where TEntity : class
{
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task<TEntity>AddAsync(TEntity entity);
}
