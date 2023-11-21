namespace API.Services.Shopping;

public interface IShopping
{
    public Task<bool> AddProductToCartCheck();
    public Task Checkout();
    public Task RetrieveCart();
}