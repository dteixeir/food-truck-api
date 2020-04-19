using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using TorrentApi.Services;
using api.Domain;

namespace api.Controllers
{
  [ApiController]
  // [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
  [Route("api/[controller]/")]
  public class FoodTruckController : BaseController<IFoodTruckService, FoodTruck>
  {
    public FoodTruckController(IFoodTruckService service) : base(service) { }
  }
}
