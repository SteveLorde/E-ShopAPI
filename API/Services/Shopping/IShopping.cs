using API.Data;
using API.Data.DTOs;
using Microsoft.EntityFrameworkCore;

namespace API.Services.Shopping;

public interface IShopping
{
    public Task<bool> AddProductToCartCheck(Guid productid);
    public Task<bool> Checkout(PurchaseLogDTO purchasetolog);
    public Task RetrieveCart();
}