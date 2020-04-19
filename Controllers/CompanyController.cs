using Microsoft.AspNetCore.Mvc;
using api.Domain;
using TorrentApi.Services;

namespace api.Controllers
{
  [ApiController]
  [Route("api/[controller]/")]
  public class CompanyController : BaseController<ICompanyService, Company>
  {
    public CompanyController(ICompanyService service) : base(service) { }
  }
}
