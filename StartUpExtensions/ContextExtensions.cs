using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using api.Domain;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

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
        }))
        .AddMvc()
        .AddJsonOptions(options =>
        {
          options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
          options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
        });

      return services;
    }
  }
}
