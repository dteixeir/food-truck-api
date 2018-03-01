using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using api.DataLayer;
using api.DataLayer.Interfaces;
using api.Domain;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace api.Controllers
{
  [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
  [Route("api/[controller]/")]
  public class FoodTruckController : Controller
  {
    internal IBaseManager _manager;

    public FoodTruckController(ApplicationDbContext context, IBaseManager baseManager)
    {
      _manager = baseManager;
    }

    // GET api/values
    [HttpGet]
    public IActionResult Get()
    {
      try 
      {
        var result = _manager.Get<FoodTruck>();
        return Ok(result);
      } 
      catch(Exception error) {
        return BadRequest(error);
      }
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public IActionResult Get(Guid id)
    {
      try 
      {
        var result = _manager.Get<FoodTruck>(id);
        return Ok(result);
      }
      catch(Exception error) 
      {
        return BadRequest(error);
      }
      
    }

    // POST api/values
    [HttpPost, Authorize]
    public IActionResult Post([FromBody]FoodTruck entity)
    {
      try
      {
        var currentUser = HttpContext.User;
        // var user = currentUser.Claims.Select(c => new {type=c.Type,value=c.Value}).ToList();
        var userId = currentUser.Claims.FirstOrDefault(c => c.Type == "User_Id")?.Value;
        entity.CreateUserId = (new Guid(userId));
        entity.CreateDateTime = DateTime.UtcNow;
        var result = _manager.Post<FoodTruck>(entity);

        return Created($"{Url.RouteUrl(RouteData.Values)}/{entity.Id}", entity);
      }
      catch(Exception error) 
      {
        return BadRequest(error);
      }
    }

    // PUT api/values/5
    [HttpPut]
    public IActionResult Put([FromBody]FoodTruck entity)
    {
      try
      {
        var result = _manager.Put<FoodTruck>(entity);
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
        var result = _manager.Delete<FoodTruck>(id);
        return NoContent();
      }
      catch(Exception error) 
      {
        return BadRequest(error);
      }
    }
  }
}
