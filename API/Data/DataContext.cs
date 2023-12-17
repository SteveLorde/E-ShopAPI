using API.Data.Models;
using Microsoft.EntityFrameworkCore;


namespace API.Data;

public class DataContext : DbContext
{
    private readonly IConfiguration _configenv;

    public DataContext(IConfiguration configenv)
    {
        _configenv = configenv;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_configenv["DatabaseConnection"]);
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ParentCategory>().HasData(
            new ParentCategory {Id = Guid.Parse("5cd3afb6-9c0f-11ee-8c90-0242ac120002"), name = "Electronics"},
            new ParentCategory {Id = Guid.Parse("672fad84-9c0f-11ee-8c90-0242ac120002"), name = "Kitchen and Appliances"},
            new ParentCategory {Id = Guid.Parse("6d8e2cc8-9c0f-11ee-8c90-0242ac120002"), name = "Groceries"},
            new ParentCategory {Id = Guid.Parse("733d2eda-9c0f-11ee-8c90-0242ac120002"), name = "Home and Garden"},
            new ParentCategory {Id = Guid.Parse("780fcde6-9c0f-11ee-8c90-0242ac120002"), name = "Beauty and Personal Care"}
        );
        
        modelBuilder.Entity<Category>().HasData(
            new Category {Id = Guid.Parse("ec5e2a09-3785-4b4b-90e6-1353ddb5aee6"), name = "Computer Hardware", ParentCategoryId = Guid.Parse("5cd3afb6-9c0f-11ee-8c90-0242ac120002") },
            new Category {Id = Guid.Parse("ec5e2a09-3785-4b4b-90e6-1353ddb5aee6"), name = "Mobiles and Accesories", ParentCategoryId = Guid.Parse("5cd3afb6-9c0f-11ee-8c90-0242ac120002") },
            new Category {Id = Guid.Parse("3ac2239f-3d70-4da0-b81e-bda272847e7c"), name = "Kitchen and Appliances", ParentCategoryId = Guid.Parse("733d2eda-9c0f-11ee-8c90-0242ac120002") },
            new Category {Id = Guid.Parse("ef39fd90-d4fd-46aa-95bf-23672f549756"), name = "Vegetables", ParentCategoryId = Guid.Parse("6d8e2cc8-9c0f-11ee-8c90-0242ac120002") },
            new Category {Id = Guid.Parse("f1c3a402-5e08-4e13-a08f-4d9ab5062a9e"), name = "Video Games", ParentCategoryId = Guid.Parse("5cd3afb6-9c0f-11ee-8c90-0242ac120002")},
            new Category {Id = Guid.Parse("bb2dc742-a510-4a83-a0fa-e454df3a559c"), name = "Tablets", ParentCategoryId = Guid.Parse("5cd3afb6-9c0f-11ee-8c90-0242ac120002")}
        );
        
        modelBuilder.Entity<News>().HasData(
            new News { Id = Guid.Parse("0f97ea1d-e247-4cf5-a6d9-5f9d3265e220"), title = "Christmas Discounts on Electronics", subtitle = null, description = "Desc Test", published = new DateOnly(2024,1,1), image = "newscover.jpg"},
            new News { Id = Guid.Parse("1a55b12e-65b8-4542-b4c1-6676c30311e7"), title = "Shop Smart, Save Big: Exclusive Year-End Sale with Unbeatable Discounts!", subtitle = null, description = "Desc Test", published = new DateOnly(2024,1,1), image = "newscover.jpg" },
            new News { Id = Guid.Parse("93097c20-6558-4ed9-a27e-8bf07fb59b8a"), title = "Digital Winter VideoGames Sales", subtitle = null, description = "Desc Test", published = new DateOnly(2024,1,1), image = "newscover.jpg" }
            );
        
        modelBuilder.Entity<Product>().HasData(
            new Product { Id = Guid.Parse("7e4788cd-77a9-4b03-9412-385a482cf489"), name = "PC Build 2024", description = "Description Test", SubCategoryId = Guid.Parse("ec5e2a09-3785-4b4b-90e6-1353ddb5aee6"), price = 500 ,images = new string[] {"1.jpg", "2.jpg" } },
            new Product { Id = Guid.Parse("694d6683-d3e6-4bc1-ab5d-f2f67f887332"), name = "My Super Awesome Health Machine", description = "Description Test", SubCategoryId = Guid.Parse("ec5e2a09-3785-4b4b-90e6-1353ddb5aee6"), price = 74,images = new string[] {"1.jpg", "2.jpg" } },
            new Product { Id = Guid.Parse("a9437a37-1d37-4a9b-adbd-a18ef0490942"), name = "Electric Koshary Machine", description = "Description Test", SubCategoryId = Guid.Parse("ec5e2a09-3785-4b4b-90e6-1353ddb5aee6"), price = 200,images = new string[] {"1.jpg", "2.jpg" } },
            new Product { Id = Guid.Parse("e9c8eccf-76aa-42d6-be67-803d8622c951"), name = "Indie Egyptian Game", description = "Description Test", SubCategoryId = Guid.Parse("ec5e2a09-3785-4b4b-90e6-1353ddb5aee6"), price = 1000,images = new string[] {"1.jpg", "2.jpg" } },
            new Product { Id = Guid.Parse("85ea5a95-5939-4261-8f8b-4d459a97f6bb"), name = "Indie Egyptian Game", description = "Description Test", SubCategoryId = Guid.Parse("ec5e2a09-3785-4b4b-90e6-1353ddb5aee6"), price = 500,images = new string[] {"1.jpg", "2.jpg" } },
            new Product { Id = Guid.Parse("d2b61d17-2707-4385-b29f-467d10452ff8"), name = "Indie Egyptian Game", description = "Description Test", SubCategoryId = Guid.Parse("ec5e2a09-3785-4b4b-90e6-1353ddb5aee6"), price = 500,images = new string[] {"1.jpg", "2.jpg" } }
        );

        modelBuilder.Entity<User>().HasData(
            new User
            { Id = Guid.Parse("c0c343f3-a9d0-4ae6-93e4-0d1923b04e60"), username = "testuser", password = "1234", pass_salt = null, hashedpassword = null, usertype = "user", phonenumber = 123456789, email = "test@gmail.com", facebook = "", profileimage = "profile.jpg"}
        );
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<News> News { get; set; }
    public DbSet<PurchaseLog> PurchaseLogs { get; set; }
    public DbSet<ParentCategory> ParentCategories { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<DiscountEvent> DiscountEvents { get; set; }
}