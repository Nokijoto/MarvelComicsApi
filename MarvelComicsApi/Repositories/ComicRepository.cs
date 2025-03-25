using MarvelComicsApi.DbConn;
using MarvelComicsApi.Dto;
using MarvelComicsApi.Interfaces;
using MarvelComicsApi.Mappers;
using Microsoft.EntityFrameworkCore;

namespace MarvelComicsApi.Repositories;

public class ComicRepository : IComicRepository
{
    private readonly AppDbContext _dbContext;
    private readonly ILogger<ComicRepository> _logger;
    public ComicRepository(AppDbContext dbContext, ILogger<ComicRepository> logger)
    {
        _dbContext = dbContext;
        _logger = logger;
    }
        
    public async Task<ComicDto> GetComic()
    {
        try
        {
            var comic = await _dbContext.Comics.FirstOrDefaultAsync();
            return comic != null ? comic.ToDto(): null;
        }
        catch (Exception e)
        {
            throw;
        }
    }
}