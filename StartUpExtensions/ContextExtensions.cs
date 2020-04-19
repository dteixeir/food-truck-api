using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using api.Domain;
using Microsoft.EntityFrameworkCore;

namespace TorrentApi.StartUpExtensions
{
  public static class ContextExtensions
  {
    public static IServiceCollection AddContext(this IServiceCollection services, IConfiguration configuration)
    {
      var connectionString = configuration.GetConnectionString("Default");
      services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString))
        .AddCors(o => o.AddPolicy("AllowAllHeaders", builder =>
        {
          builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
        }));

      return services;
    }
  }
}
