using API.Data.Models;

namespace API.Services.NewsRepository;

public interface INewsRepository
{
    public Task<List<News>> GetNews();
    public Task AddNews(News newstoadd);
    public Task UpdateNews(News newstoupdate);
    public Task RemoveNews(News newstoremove);
}