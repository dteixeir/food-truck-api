using api.Domain;
using TorrentApi.Repositories;

namespace TorrentApi.Services
{
  public interface IFoodTruckService : IService<FoodTruck>
  { }

  public class FoodTruckService : BaseService<FoodTruck>, IFoodTruckService
  {
    public FoodTruckService(IRepository<FoodTruck> repository) : base(repository)
    { }
  }
}