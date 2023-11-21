using API.Data.DTOs;

namespace API.Services.ProductsRepository;

public interface IProductsRepository
{
    public Task GetProducts();
    public Task GetProductsByCategory(string category);
    public Task AddProduct(ProductDTO producttoadd);
    public Task UpdateProduct(ProductDTO producttoupdate);
    public Task RemoveProduct(ProductDTO producttoremove);

}