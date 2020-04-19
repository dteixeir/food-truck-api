using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System;
using TorrentApi.Services;
using api.Domain;

public abstract class BaseController<TService, TEntity> : ControllerBase
  where TEntity : BaseEntity
  where TService : IService<TEntity>
{
  protected TService _service;

  public BaseController(TService service)
  {
    _service = service;
  }

  [HttpGet]
  public async Task<IActionResult> Get()
  {
    List<TEntity> response = await _service.Get();
    return Ok(response);
  }

  [HttpGet("{id}")]
  public async Task<IActionResult> Get(Guid id)
  {
    TEntity response = await _service.Get(id);
    return Ok(response);
  }

  [HttpPut]
  public async Task<IActionResult> Put([FromBody] List<TEntity> items)
  {
    List<TEntity> result = await _service.Update(items);
    return Ok(items);
  }

  [HttpPost]
  public async Task<IActionResult> Post([FromBody] List<TEntity> items)
  {
    List<TEntity> result = await _service.Add(items);
    return Ok(items);
  }

  [HttpDelete("{id}")]
  public async Task<IActionResult> Delete(Guid id)
  {
    Guid result = await _service.Delete(id);
    return Ok();
  }
}