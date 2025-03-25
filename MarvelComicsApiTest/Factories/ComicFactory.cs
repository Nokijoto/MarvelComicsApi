using Bogus;
using MarvelComicsApi.Entities;
using MarvelComicsApi.Dto;
namespace MarvelComicsApiTest.Factories;

public class ComicFactory
{
    
    private readonly Faker<Comic> _comicFaker;
    private readonly Faker<ComicDto> _comicDtoFaker;
    public ComicFactory()
    {
        _comicFaker = new Faker<Comic>()
            .RuleFor(c => c.Id, f => f.Random.Guid())
            .RuleFor(c => c.ComicName, f => f.Random.String())
            .RuleFor(c => c.IssueDescription, f => f.Random.String())
            .RuleFor(c => c.IssueTitle, f => f.Random.String())
            .RuleFor(c => c.Penciler, f => f.Random.String())
            .RuleFor(c => c.Writer, f => f.Random.String())
            .RuleFor(c => c.CoverArtist, f => f.Random.String())
            .RuleFor(c => c.Imprint, f => f.Random.String())
            .RuleFor(c => c.CreatedAt, f => f.Date.Past())
            .RuleFor(c => c.UpdatedAt, f => f.Date.Past())
            .RuleFor(c => c.DeletedAt, f => f.Date.Past());
        
        _comicDtoFaker = new Faker<ComicDto>()
            .RuleFor(c => c.Id, f => f.Random.Guid())
            .RuleFor(c => c.ComicName, f => f.Random.String())
            .RuleFor(c => c.IssueDescription, f => f.Random.String())
            .RuleFor(c => c.IssueTitle, f => f.Random.String())
            .RuleFor( c=> c.Penciler, f => f.Random.String())
            .RuleFor(c => c.Writer, f => f.Random.String())
            .RuleFor(c => c.CoverArtist, f => f.Random.String())
            .RuleFor(c => c.Imprint, f => f.Random.String())
            .RuleFor(c => c.CreatedAt, f => f.Date.Past())
            .RuleFor(c => c.UpdatedAt, f => f.Date.Past())
            .RuleFor(c => c.DeletedAt, f => f.Date.Past());
    }
    
    public Comic Create()
    {
        return _comicFaker.Generate();
    }
    
    public ComicDto CreateDto()
    {
        return _comicDtoFaker.Generate();
    }   
    
    public List<Comic> CreateMany(int count)
    {
        return _comicFaker.Generate(count);
    }
    
    public List<ComicDto> CreateManyDto(int count)
    {
        return _comicDtoFaker.Generate(count);
    }   
}