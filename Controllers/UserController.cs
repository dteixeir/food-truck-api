using Microsoft.AspNetCore.Mvc;
using TorrentApi.Services;
using api.Domain;

namespace api.Controllers
{
  [ApiController]
  [Route("api/[controller]/")]
  public class UserController : BaseController<IUserService, User>
  {
    public UserController(IUserService service) : base(service) { }
  }
}
