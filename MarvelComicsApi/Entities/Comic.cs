namespace MarvelComicsApi.Entities;

public class Comic :BaseEntity
{
    public string ComicName { get; set; }
    public string ActiveYears { get; set; }
    public string IssueTitle { get; set; }
    public string PublishDate { get; set; }
    public string IssueDescription { get; set; }
    public string Penciler { get; set; }
    public string Writer { get; set; }
    public string CoverArtist { get; set; }
    public string Imprint { get; set; }
    public string Format { get; set; }
    public string Rating { get; set; }
    public string Price { get; set; }

}