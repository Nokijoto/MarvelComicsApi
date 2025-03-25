using MarvelComicsApi.Dto;

namespace MarvelComicsApi.Responses;

public class ComicResponse :ComicDto
{
    public ComicResponse(ComicDto comicDto)
    {
        this.Id = comicDto.Id;
        this.ActiveYears = comicDto.ActiveYears;
        this.ComicName = comicDto.ComicName;
        this.IssueDescription = comicDto. IssueDescription;
        this.PublishDate = comicDto.PublishDate;
        this.IssueDescription= comicDto.IssueDescription;
        this.Penciler = comicDto.Penciler;
        this.Writer= comicDto.Writer;
        this.CoverArtist = comicDto.CoverArtist;
        this.Imprint = comicDto.Imprint;
        this.Format = comicDto.Format;
        this.Rating = comicDto.Rating;
        this.Price = comicDto.Price;
        this.CreatedAt = comicDto.CreatedAt;
        this.UpdatedAt = comicDto.UpdatedAt;
        this.DeletedAt = comicDto.DeletedAt;
    }   
}