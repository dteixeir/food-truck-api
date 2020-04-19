
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using api.Domain;
using Microsoft.EntityFrameworkCore;
using TorrentApi.Repositories;

namespace TorrentApi.Services
{
  public interface IService<TEntity> where TEntity : BaseEntity
  {
    void Include(string[] includes);
    Task<TEntity> Add(TEntity item);
    Task<List<TEntity>> Add(List<TEntity> item);
    Task<Guid> Delete(Guid id);
    Task<List<TEntity>> Get();
    Task<TEntity> Get(Guid id);
    Task<TEntity> Update(TEntity item);
    Task<List<TEntity>> Update(List<TEntity> items);
    DbSet<TEntity> DbSet();
  }

  public class BaseService<TEntity> : IService<TEntity> where TEntity : BaseEntity
  {
    protected readonly IRepository<TEntity> _repository;
    private readonly int _takeCount = 10;


    public BaseService(IRepository<TEntity> repository)
    {
      _repository = repository;
    }

    public DbSet<TEntity> DbSet() => _repository.DbSet();

    public void Include(string[] includes)
    {
      foreach (var include in includes)
      {
        DbSet().Include(include);
      }
    }

    // get
    public virtual async Task<List<TEntity>> Get()
    {
      return await _repository.Get().ToListAsync();
    }

    public virtual async Task<TEntity> Get(Guid id)
    {
      return await _repository.Get(id).FirstOrDefaultAsync();
    }

    // put
    public virtual async Task<TEntity> Update(TEntity item)
    {
      return await _repository.Update(item);
    }
    public virtual async Task<List<TEntity>> Update(List<TEntity> items)
    {
      return await _repository.Update(items);
    }

    // post
    public virtual async Task<TEntity> Add(TEntity item)
    {
      return await _repository.Add(item);
    }
    public virtual async Task<List<TEntity>> Add(List<TEntity> items)
    {
      return await _repository.Add(items);
    }

    // delete
    public async Task<Guid> Delete(Guid id)
    {
      return await _repository.Delete(id);
    }
  }
}