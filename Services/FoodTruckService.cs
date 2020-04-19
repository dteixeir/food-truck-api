using System;
using System.Threading.Tasks;
using api.Domain;
using Microsoft.EntityFrameworkCore;
using TorrentApi.Repositories;

namespace TorrentApi.Services
{
  public interface IFoodTruckService : IService<FoodTruck>
  { }

  public class FoodTruckService : BaseService<FoodTruck>, IFoodTruckService
  {
    public FoodTruckService(IRepository<FoodTruck> repository) : base(repository)
    { }

    public override async Task<FoodTruck> Get(Guid id)
    {
      var result = await _repository.Get(id)
        .Include(x => x.Company)
        .FirstOrDefaultAsync();

      return result;
    }
  }
}