using MarvelComicsApi.Responses;

namespace MarvelComicsApi.Interfaces;

public interface IComicService
{
    public Task<ComicResponse> GetComic();
}