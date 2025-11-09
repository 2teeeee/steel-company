namespace SteelCompany.Api.Models;

public class Product
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Slug { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Language { get; set; } = "fa";
    public string? ImageUrl { get; set; }
}