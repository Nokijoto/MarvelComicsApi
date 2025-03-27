using Microsoft.AspNetCore.Mvc;

namespace MarvelComicsApi.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class VersionController
{
    [HttpGet]
    public string Get()
    {
        return "1.0.0";
    }
}