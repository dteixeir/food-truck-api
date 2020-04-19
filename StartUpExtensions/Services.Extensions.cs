using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using api.Domain;
using api.DataLayer.Interfaces;
using api.DataLayer;
using TorrentApi.Services;
using TorrentApi.Repositories;

namespace TorrentApi.StartUpExtensions
{
  public static class ServicesExtensions
  {
    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
    {
      // services.AddTransient<IAuthManager, AuthManager>();
      services.AddTransient<IApplicationDbContext, ApplicationDbContext>();

      services.AddTransient<IRepository<Company>, BaseRepository<Company>>();
      services.AddTransient<ICompanyService, CompanyService>();

      services.AddTransient<IRepository<FoodTruck>, BaseRepository<FoodTruck>>();
      services.AddTransient<IFoodTruckService, FoodTruckService>();

      services.AddTransient<IRepository<Menu>, BaseRepository<Menu>>();
      services.AddTransient<IMenuService, MenuService>();

      services.AddTransient<IRepository<MenuItem>, BaseRepository<MenuItem>>();
      services.AddTransient<IMenuItemService, MenuItemService>();

      services.AddTransient<IRepository<ScheduleItem>, BaseRepository<ScheduleItem>>();
      services.AddTransient<IScheduleItemService, ScheduleItemService>();

      services.AddTransient<IRepository<User>, BaseRepository<User>>();
      services.AddTransient<IUserService, UserService>();

      return services;
    }
  }
}
