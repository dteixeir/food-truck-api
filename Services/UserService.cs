using api.Domain;
using TorrentApi.Repositories;

namespace TorrentApi.Services
{
  public interface IUserService : IService<User>
  { }

  public class UserService : BaseService<User>, IUserService
  {
    public UserService(IRepository<User> repository) : base(repository)
    { }
  }
}