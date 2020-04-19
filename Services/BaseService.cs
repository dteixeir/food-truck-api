
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using api.Domain;
using Microsoft.EntityFrameworkCore;
using TorrentApi.Repositories;

namespace TorrentApi.Services
{
  public interface IService<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
  { }

  public class BaseService<TEntity> : IService<TEntity> where TEntity : BaseEntity
  {
    protected readonly IRepository<TEntity> _repository;

    public BaseService(IRepository<TEntity> repository)
    {
      _repository = repository;
    }

    public DbSet<TEntity> DbSet() => _repository.DbSet();

    // get
    public virtual async Task<List<TEntity>> Get()
    {
      return await _repository.Get();
    }
    public virtual async Task<TEntity> Get(Guid id)
    {
      return await _repository.Get(id);
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