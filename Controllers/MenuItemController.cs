using Microsoft.AspNetCore.Mvc;
using TorrentApi.Services;
using api.Domain;

namespace api.Controllers
{
  [ApiController]
  [Route("api/[controller]/")]
  public class MenuItemController : BaseController<IMenuItemService, MenuItem>
  {
    public MenuItemController(IMenuItemService service) : base(service) { }
  }
}
