using API.Data;
using API.Services.NewsRepository;
using API.Services.ProductsRepository;
using Microsoft.EntityFrameworkCore;

namespace API.Services.StartupService;

public class Startup
{
    private readonly IServiceProvider _serviceprovider;

    public Startup(IServiceProvider serviceProvider)
    {
        _serviceprovider = serviceProvider;
    }

    public void ExecuteServices()
    {
        var scopedb = _serviceprovider.CreateScope();
        var servicedb = scopedb.ServiceProvider;
        var dbservice = servicedb.GetRequiredService<DataContext>();
        dbservice.Database.Migrate();
        Console.WriteLine("Database Found/Created");
        var scope1 = _serviceprovider.CreateScope();
        var servicescoper1 = scope1.ServiceProvider;
        var newsservice = servicescoper1.GetRequiredService<INewsRepository>();
        newsservice.CreateNewsFolders();
        var scope2 = _serviceprovider.CreateScope();
        var servicescoper2 = scope2.ServiceProvider;
        var productservice = servicescoper2.GetRequiredService<IProductsRepository>();
        productservice.CreateAssetsFolders();
    }
        
        
}