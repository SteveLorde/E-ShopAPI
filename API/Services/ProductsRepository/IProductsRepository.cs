namespace API.Services.ProductsRepository;

public interface IProductsRepository
{
    public Task GetProducts();
    public Task GetProductsByCategory();
    
}