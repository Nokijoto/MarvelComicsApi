using MarvelComicsApi.DbConn;
using MarvelComicsApi.Dto;
using MarvelComicsApi.Interfaces;
using MarvelComicsApi.Mappers;
using Microsoft.EntityFrameworkCore;

namespace MarvelComicsApi.Repositories;

public class ComicRepository : IComicRepository
{
    private readonly AppDbContext _dbContext;
    public ComicRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
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