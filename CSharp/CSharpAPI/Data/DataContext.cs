
using CSharpAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CSharpAPI.Data
{
   
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Destiny> Destinys { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<Destiny>().HasData(
        new Destiny { Id = 1, Name = "Cachoeira do Mosquito", City = "Lençois", ImageUrls = ["https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/1b6270da-85f9-452d-8f11-9e486522397a", "https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/7da3cc7f-75cd-41aa-a2fb-a133e90d1b21"] },
        new Destiny { Id = 2, Name = "Pratinha", City = "Iraquara", ImageUrls = ["https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/d1f4942a-4d4e-417a-9445-7117b1648cfa", "https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/7b90c8d5-e3bf-4132-a281-615db90e23b4"] }
      );
    }  
  } 
}