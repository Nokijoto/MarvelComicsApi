
using MarvelComicsApi.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace MarvelComicsApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ComicController : ControllerBase
{
    public readonly IComicService _comicService;
    public ComicController(IComicService comicService)
    {
        _comicService = comicService;
    }
    
    
    [HttpGet(Name = "GetComic")]
    public async Task<IActionResult> Get()
    {
        try
        {
            var result = await _comicService.GetComic();
            return Ok(result);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return NoContent();
        }
    }
    
}

