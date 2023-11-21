using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("Shopping")]
public class ShoppingController : Controller
{
    [HttpGet("AddToCartCheck/${id}")]
    public IActionResult AddToCartCheck(int productid)
    {
        return View();
    }
}