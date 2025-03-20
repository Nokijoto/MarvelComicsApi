using MarvelComicsApi.Interfaces;
using MarvelComicsApi.Responses;

namespace MarvelComicsApi.Services;

public class ComicService : IComicService
{
    public readonly IComicRepository _comicRepository;
    
    public ComicService(IComicRepository comicRepository)
    {
        _comicRepository = comicRepository;
    }
    public async Task<ComicResponse> GetComic()
    {
        try
        {
            var comic = await _comicRepository.GetComic();
            return new ComicResponse(comic);
        }
        catch (Exception e)
        {
            throw;
        }   
        
    }
}