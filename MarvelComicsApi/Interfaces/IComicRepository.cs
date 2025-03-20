using MarvelComicsApi.Dto;
using MarvelComicsApi.Entities;

namespace MarvelComicsApi.Interfaces;

public interface IComicRepository
{
    public  Task<ComicDto> GetComic();
}