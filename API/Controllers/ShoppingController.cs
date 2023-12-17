using API.Data.DTOs;
using API.Services.Shopping;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

/*
[Authorize]
*/
[ApiController]
[Route("Shopping")]
public class ShoppingController : Controller
{
    private readonly IShopping _shoppingservice;

    public ShoppingController(IShopping shoppingservice)
    {
        _shoppingservice = shoppingservice;
    }
    
    [HttpPost("Checkout")]
    public async Task<bool> Checkout(PurchaseLogDTO purchasetolog)
    {
        try
        {
            var check = await _shoppingservice.Checkout(purchasetolog);
            return check;
        }
        catch (Exception err)
        {
            throw err;
        }
    }
    
    [HttpGet("AddToCartCheck/${id}")]
    public IActionResult AddToCartCheck(int productid)
    {
        return Ok();
    }
}