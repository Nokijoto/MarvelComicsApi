using MarvelComicsApi.Dto;
using MarvelComicsApi.Entities;

namespace MarvelComicsApi.Mappers;

public static class ComicMapper
{
    public static Comic ToEntity(this ComicDto comic)
    {
        return new Comic()
        {
            Id = comic.Id,
            ActiveYears = comic.ActiveYears,
            ComicName = comic.ComicName,
            CoverArtist = comic.CoverArtist,
            IssueDescription = comic.IssueDescription,
            IssueTitle = comic.IssueTitle,
            Penciler = comic.Penciler,
            PublishDate = comic.PublishDate,
            Writer = comic.Writer,
            Format = comic.Format,
            Imprint = comic.Imprint,
            Price = comic.Price,
            Rating = comic.Rating,
            CreatedAt = comic.CreatedAt,
            UpdatedAt = comic.UpdatedAt,
            DeletedAt = comic.DeletedAt,
        };
    }
    
    public static ComicDto ToDto(this Comic comic)
    {
        return new ComicDto()
        {
            Id = comic.Id,
            ActiveYears = comic.ActiveYears,
            ComicName = comic.ComicName,
            CoverArtist = comic.CoverArtist,
            IssueDescription = comic.IssueDescription,
            IssueTitle = comic.IssueTitle,
            Penciler = comic.Penciler,
            PublishDate = comic.PublishDate,
            Writer = comic.Writer,
            Format = comic.Format,
            Imprint = comic.Imprint,
            Price = comic.Price,
            Rating = comic.Rating,
            CreatedAt = comic.CreatedAt,
            UpdatedAt = comic.UpdatedAt,
            DeletedAt = comic.DeletedAt,
        };
    }
}