using System.IO;
using Microsoft.EntityFrameworkCore;

namespace api.Domain
{
  public class ApplicationDbContext : DbContext
  {
    public DbSet<FoodTruck> FoodTrucks {get; set;}

    public DbSet<Menu> Menus {get; set;}
    
    public DbSet<MenuItem> MenuItems {get; set;}

    public DbSet<ScheduleItem> ScheduleItems {get; set;}

    public DbSet<User> Users {get; set;}

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    { 

    }

    // public DbSet<FoodTruck> FoodTrucks { get; set; }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     if (!optionsBuilder.IsConfigured)
    //     {
    //         #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
    //         optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True;");
    //     }
    // }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //   optionsBuilder.UseSql("Filename=./beer.db");
    // }
  }
}