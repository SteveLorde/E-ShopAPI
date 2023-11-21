using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("Warehouse")]
public class WarehouseController : Controller
{
    [HttpGet("GetWeatherForecast")]
    public IActionResult Index()
    {
        return View();
    }
    
}