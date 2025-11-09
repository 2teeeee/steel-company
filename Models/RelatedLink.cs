namespace SteelCompany.Api.Models;

public class RelatedLink
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Url { get; set; } = null!;
    public int Order { get; set; } = 0;
}