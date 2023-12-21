using API.Data.DTOs;
using API.Data.Models;

namespace API.Services.ProductsRepository;

public interface IProductsRepository
{
    public Task<List<Product>> GetProducts();
    public Task<Product> GetProduct(string productid);
    public Task<List<Product>> GetMostSelling();
    public Task<List<Category>> GetCategories();
    public Task<List<ParentCategory>> GetParentCategories();
    public Task CreateAssetsFolders();
    public Task<List<Product>> GetProductsByCategory(string categoryid);
    public Task AddProduct(ProductDTO producttoadd);
    public Task AddQuantity(string productid);
    public Task RemoveQuantity(string productid);
    public Task UpdateProduct(ProductDTO producttoupdate);
    public Task RemoveProduct(ProductDTO producttoremove);

}