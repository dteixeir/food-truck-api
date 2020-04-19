using api.Domain;
using TorrentApi.Repositories;

namespace TorrentApi.Services
{
  public interface IScheduleItemService : IService<ScheduleItem>
  { }

  public class ScheduleItemService : BaseService<ScheduleItem>, IScheduleItemService
  {
    public ScheduleItemService(IRepository<ScheduleItem> repository) : base(repository)
    { }
  }
}