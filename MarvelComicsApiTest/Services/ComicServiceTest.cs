using MarvelComicsApi.Interfaces;
using MarvelComicsApi.Mappers;
using MarvelComicsApi.Repositories;
using MarvelComicsApi.Services;
using MarvelComicsApiTest.Factories;
using Microsoft.Extensions.Logging;
using Moq;
namespace MarvelComicsApiTest.Services;

public class ComicServiceTest
{
    private readonly IComicService _comicService;
    private readonly Mock<IComicRepository> _mockedComicRepository;
    private readonly ComicFactory _comicFactory;
    public ComicServiceTest()
    {
        _comicFactory = new ComicFactory();
        _mockedComicRepository= new Mock<IComicRepository>();
        _comicService = new ComicService(_mockedComicRepository.Object);
    }

    [Fact]
    public async Task GetComicAsyncTest()
    {        
        var comic =_comicFactory.Create();

        _mockedComicRepository.Setup(repo => repo.GetComic()).ReturnsAsync(comic.ToDto());
        
        var result = await _comicService.GetComic();
        
        
        
        Assert.NotNull(comic);        
    }
}