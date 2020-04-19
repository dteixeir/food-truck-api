using api.Domain;
using TorrentApi.Repositories;

namespace TorrentApi.Services
{
  public interface IMenuItemService : IService<MenuItem>
  { }

  public class MenuItemService : BaseService<MenuItem>, IMenuItemService
  {
    public MenuItemService(IRepository<MenuItem> repository) : base(repository)
    { }
  }
}