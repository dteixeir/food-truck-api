using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using api.Domain;
using api.DataLayer.Interfaces;
using api.DataLayer;

namespace TorrentApi.StartUpExtensions
{
  public static class ServicesExtensions
  {
    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
    {
      services.AddTransient<IAuthManager, AuthManager>();
      services.AddTransient<IBaseManager, BaseManager>();
      services.AddTransient<IApplicationDbContext, ApplicationDbContext>();

      return services;
    }
  }
}
