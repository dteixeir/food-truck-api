using api.Domain;
using Microsoft.AspNetCore.Mvc;
using TorrentApi.Services;

namespace api.Controllers
{
  [ApiController]
  [Route("api/[controller]/")]
  public class MenuController : BaseController<IMenuService, Menu>
  {
    public MenuController(IMenuService service) : base(service) { }
  }
}
