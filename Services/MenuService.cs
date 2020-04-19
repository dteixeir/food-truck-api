using api.Domain;
using TorrentApi.Repositories;

namespace TorrentApi.Services
{
  public interface IMenuService : IService<Menu>
  { }

  public class MenuService : BaseService<Menu>, IMenuService
  {
    public MenuService(IRepository<Menu> repository) : base(repository)
    { }
  }
}