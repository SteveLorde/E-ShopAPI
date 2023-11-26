using API.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Database=EShop;Username=postgres;Password=World2050");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<News>().HasData(
            new News { NewsId = 1, title = "News 1", subtitle = null, description = "Desc Test", published = new DateOnly(2024,1,1) },
            new News { NewsId = 2, title = "News 2", subtitle = null, description = "Desc Test", published = new DateOnly(2024,1,1) },
            new News { NewsId = 3, title = "News 3", subtitle = null, description = "Desc Test", published = new DateOnly(2024,1,1) }
        );
        
        
        modelBuilder.Entity<Product>().HasData(
            new Product { ProductId = Guid.NewGuid(), name = "Product 1", description = "Desc Test", descriptionbullets = null, quantity = 50, price = 500, addedon = null, discount = null, sells = 500},
            new Product { ProductId = Guid.NewGuid(), name = "Product 2", description = "Desc Test", descriptionbullets = null, quantity = 10, price = 500, addedon = null, discount = null, sells = 50 },
            new Product { ProductId = Guid.NewGuid(), name = "Product 3", description = "Desc Test", descriptionbullets = null, quantity = 1, price = 500, addedon = null, discount = null, sells = 15 },
            new Product { ProductId = Guid.NewGuid(), name = "Product 4", description = "Desc Test", descriptionbullets = null, quantity = 5, price = 500, addedon = null, discount = null, sells = 40},
            new Product { ProductId = Guid.NewGuid(), name = "Product 5", description = "Desc Test", descriptionbullets = null, quantity = 4, price = 500, addedon = null, discount = null, sells = 1},
            new Product { ProductId = Guid.NewGuid(), name = "Product 6", description = "Desc Test", descriptionbullets = null, quantity = 6, price = 500, addedon = null, discount = null, sells = 25},
            new Product { ProductId = Guid.NewGuid(), name = "Product 7", description = "Desc Test", descriptionbullets = null, quantity = 7, price = 500, addedon = null, discount = null, sells = 0},
            new Product { ProductId = Guid.NewGuid(), name = "Product 8", description = "Desc Test", descriptionbullets = null, quantity = 0, price = 500, addedon = null, discount = null, sells = 0}
            );
        
        modelBuilder.Entity<User>().HasData(
            new User { UserId = Guid.NewGuid(), username = "admintest", password = "123456", usertype = "admin" },
            new User { UserId = Guid.NewGuid(), username = "usertest", password = "123456", usertype = "user" }
        );
        
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<News> News { get; set; }
}