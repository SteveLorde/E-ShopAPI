using API.Data.Models;
using DefaultNamespace;
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
        modelBuilder.Entity<Product>().HasData(
            new Product { ProductId = 1, name = "Product 1", description = "Desc Test", descriptionbullets = null, price = 500, addedon = null, discount = null },
            new Product { ProductId = 2, name = "Product 2", description = "Desc Test", descriptionbullets = null, price = 500, addedon = null, discount = null },
            new Product { ProductId = 3, name = "Product 3", description = "Desc Test", descriptionbullets = null, price = 500, addedon = null, discount = null },
            new Product { ProductId = 4, name = "Product 4", description = "Desc Test", descriptionbullets = null, price = 500, addedon = null, discount = null },
            new Product { ProductId = 5, name = "Product 5", description = "Desc Test", descriptionbullets = null, price = 500, addedon = null, discount = null },
            new Product { ProductId = 6, name = "Product 6", description = "Desc Test", descriptionbullets = null, price = 500, addedon = null, discount = null },
            new Product { ProductId = 7, name = "Product 7", description = "Desc Test", descriptionbullets = null, price = 500, addedon = null, discount = null },
            new Product { ProductId = 8, name = "Product 8", description = "Desc Test", descriptionbullets = null, price = 500, addedon = null, discount = null }
            );
        
        modelBuilder.Entity<User>().HasData(
            new User { UserId = 1, username = "admintest", password = "123456", usertype = "admin" },
            new User { UserId = 2, username = "usertest", password = "123456", usertype = "user" }
        );
        
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<News> News { get; set; }
}