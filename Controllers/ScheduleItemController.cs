using Microsoft.AspNetCore.Mvc;
using TorrentApi.Services;
using api.Domain;

namespace api.Controllers
{
  [ApiController]
  [Route("api/[controller]/")]
  public class ScheduleItemController : BaseController<IScheduleItemService, ScheduleItem>
  {
    public ScheduleItemController(IScheduleItemService service) : base(service) { }
  }
}
