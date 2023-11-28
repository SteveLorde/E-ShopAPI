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
    [HttpGet("AddToCartCheck/${id}")]
    public IActionResult AddToCartCheck(int productid)
    {
        return Ok();
    }
}