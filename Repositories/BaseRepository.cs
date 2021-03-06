using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using api.Domain;

namespace TorrentApi.Repositories
{
  public interface IRepository<TEntity> where TEntity : BaseEntity
  {
    // DbSet<TEntity> Include(string[] includes);
    Task<TEntity> Add(TEntity item);
    Task<List<TEntity>> Add(List<TEntity> item);
    Task<Guid> Delete(Guid id);
    IQueryable<TEntity> Get();
    IQueryable<TEntity> Get(Guid id);
    Task<TEntity> Update(TEntity item);
    Task<List<TEntity>> Update(List<TEntity> items);
    DbSet<TEntity> DbSet();
  }

  public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
  {
    private ApplicationDbContext _context;
    private readonly DbSet<TEntity> _dbSet;

    public BaseRepository(ApplicationDbContext context)
    {
      _context = context;
      _dbSet = _context.Set<TEntity>();
    }

    public DbSet<TEntity> DbSet() => _dbSet;

    public IQueryable<TEntity> Get()
    {
      return _dbSet.AsQueryable();
    }

    public IQueryable<TEntity> Get(Guid id)
    {
      return _dbSet.Where(x => x.Id == id).AsQueryable();
    }

    public async Task<TEntity> Update(TEntity item)
    {
      _dbSet.Update(item);
      await _context.SaveChangesAsync();

      return item;
    }

    public async Task<List<TEntity>> Update(List<TEntity> items)
    {
      _dbSet.UpdateRange(items);
      await _context.SaveChangesAsync();

      return items;
    }

    public async Task<TEntity> Add(TEntity item)
    {
      await _dbSet.AddAsync(item);
      await _context.SaveChangesAsync();

      return item;
    }

    public async Task<List<TEntity>> Add(List<TEntity> items)
    {
      await _dbSet.AddRangeAsync(items);
      await _context.SaveChangesAsync();

      return items;
    }

    public async Task<Guid> Delete(Guid id)
    {
      TEntity item = await _dbSet.SingleOrDefaultAsync(x => x.Id == id);
      _dbSet.Remove(item);
      await _context.SaveChangesAsync();

      return id;
    }
  }
}