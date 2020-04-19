using api.Domain;
using TorrentApi.Repositories;

namespace TorrentApi.Services
{
  public interface ICompanyService : IService<Company>
  { }

  public class CompanyService : BaseService<Company>, ICompanyService
  {
    public CompanyService(IRepository<Company> repository) : base(repository)
    { }
  }
}