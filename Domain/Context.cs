using System.IO;
using Microsoft.EntityFrameworkCore;

namespace api.Domain
{
  public class ApplicationDbContext : DbContext, IApplicationDbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Company> Companies { get; set; }

    public DbSet<FoodTruck> FoodTrucks { get; set; }

    public DbSet<Menu> Menus { get; set; }

    public DbSet<MenuItem> MenuItems { get; set; }

    public DbSet<ScheduleItem> ScheduleItems { get; set; }

    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<User>().HasIndex(u => u.Username).IsUnique();
    }
  }
}