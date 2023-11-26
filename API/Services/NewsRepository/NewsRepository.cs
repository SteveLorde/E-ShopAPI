using API.Data;
using API.Data.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace API.Services.NewsRepository;

class NewsRepository : INewsRepository
{
    
    private readonly DataContext _db;
    private readonly IMapper _mapper;

    public NewsRepository(DataContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }
    
    public async Task<List<News>> GetNews()
    {
        return await _db.News.ToListAsync();
    }

    public async Task AddNews(News newstoadd)
    {
        await _db.News.AddAsync(newstoadd);
    }

    public async Task UpdateNews(News newstoupdate)
    {
        News selectednews = await _db.News.FirstAsync(x => x.NewsId == newstoupdate.NewsId);
        selectednews = newstoupdate;
        await _db.SaveChangesAsync();
    }

    public async Task RemoveNews(News newstoremove)
    {
        News selectednews = await _db.News.FirstAsync(x => x.NewsId == newstoremove.NewsId);
        _db.News.Remove(selectednews);
        await _db.SaveChangesAsync();
    }
    
}