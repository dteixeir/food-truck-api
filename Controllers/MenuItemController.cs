using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using api.DataLayer;
using api.DataLayer.Interfaces;
using api.Domain;

namespace api.Controllers
{

  [Route("api/[controller]/")]
  public class MenuItemController : Controller
  {
    internal IService _manager;

    public MenuItemController(ApplicationDbContext context)
    {
      _manager = new BaseManager(context);
    }

    // GET api/values
    [HttpGet]
    public IActionResult Get()
    {
      try
      {
        var result = _manager.Get<MenuItem>();
        return Ok(result);
      }
      catch(Exception error) 
      {
        return BadRequest(error);
      }
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public IActionResult Get(Guid id)
    {
      try
      {
        var result = _manager.Get<MenuItem>(id);
        return Ok(result);
      }
      catch(Exception error) 
      {
        return BadRequest(error);
      }
    }

    // POST api/values
    [HttpPost]
    public IActionResult Post([FromBody]MenuItem entity)
    {
      try
      {
        var result = _manager.Post<MenuItem>(entity);
        return Created($"{Url.RouteUrl(RouteData.Values)}/{entity.Id}", entity);
      }
      catch(Exception error) 
      {
        return BadRequest(error);
      }
    }

    // PUT api/values/5
    [HttpPut]
    public IActionResult Put([FromBody]MenuItem entity)
    {
      try
      {
        var result = _manager.Put<MenuItem>(entity);
        return Ok(result);
      }
      catch(Exception error) 
      {
        return BadRequest(error);
      }
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
      try
      {
        var result = _manager.Delete<MenuItem>(id);
        return NoContent();
      }
      catch(Exception error) 
      {
        return BadRequest(error);
      }
    }
  }
}
