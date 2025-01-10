using System;
using Elif.Data.Abstract;
using Elif.Data.Concrete.Context;
using Microsoft.EntityFrameworkCore;

namespace Elif.Data.Concrete;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
{
    private readonly AppDbContext _dbcontext;
    private readonly DbSet<TEntity> _dbset;
    public GenericRepository(AppDbContext dbcontext, DbSet<TEntity> dbset)
    {
        _dbcontext = dbcontext;
        _dbset = _dbcontext.Set<TEntity>();
    }

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        await _dbset.AddAsync(entity);
        return entity;
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _dbset.ToListAsync();
    }
}
