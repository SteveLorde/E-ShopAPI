using API.Data.DTOs;
using API.Data.Models;

namespace API.Services.ProductsRepository;

public interface IProductsRepository
{
    public Task<List<Product>> GetProducts();
    public Task<List<Product>> GetProductsByCategory(string category);
    public Task AddProduct(ProductDTO producttoadd);
    public Task UpdateProduct(ProductDTO producttoupdate);
    public Task RemoveProduct(ProductDTO producttoremove);

}