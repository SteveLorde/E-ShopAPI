using API.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Services.Shopping;

public interface IShopping
{
    public Task<bool> AddProductToCartCheck(Guid productid);
    public Task Checkout();
    public Task RetrieveCart();
}

class Shopping : IShopping
{
    private readonly DataContext _db;

    public Shopping(DataContext db)
    {
        _db = db;
    }

    public async Task<bool> AddProductToCartCheck(Guid productid)
    {
        return await _db.Products.AnyAsync(x => x.ProductId == productid);
    }

    public async Task Checkout()
    {
        throw new NotImplementedException();
    }

    public async Task RetrieveCart()
    {
        throw new NotImplementedException();
    }
}