namespace SteelCompany.Api.Models;

public class Page
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Slug { get; set; } = null!;
    public string Content { get; set; } = null!;
    public string Language { get; set; } = "fa"; // fa, en, ar ...
    public DateTime? PublishedAt { get; set; }
}