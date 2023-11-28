using API.Data.Models;
using API.Services.NewsRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

/*
[Authorize]
*/
[ApiController]
[Route("News")]
public class NewsController : Controller
{
    private readonly INewsRepository _newsrepo;

    public NewsController(INewsRepository newsrepo)
    {
        _newsrepo = newsrepo;
    }
    
    
    [HttpGet("GetNews")]
    public async Task<List<News>> GetNews()
    {
        return await _newsrepo.GetNews();
    }
    
    
    
}