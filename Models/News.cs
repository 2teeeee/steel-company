namespace SteelCompany.Api.Models;

public class News
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Slug { get; set; } = null!;
    public string Content { get; set; } = null!;
    public DateTime PublishedAt { get; set; } = DateTime.UtcNow;
    public string Language { get; set; } = "fa";
}