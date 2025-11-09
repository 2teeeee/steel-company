using SteelCompany.Api.Models;

namespace SteelCompany.Api.Data;

public static class DbInitializer
{
    public static void Initialize(AppDbContext db)
    {
        if (!db.News.Any())
        {
            db.News.AddRange(new []
            {
                new News { Title = "افتتاح خط تولید جدید", Slug = "new-line", Content = "افتتاح خط تولید میلگرد ...", Language = "fa", PublishedAt = DateTime.UtcNow.AddDays(-5) },
                new News { Title = "Export contract signed", Slug = "export-contract", Content = "We signed a major contract ...", Language = "en", PublishedAt = DateTime.UtcNow.AddDays(-2) }
            });
            db.SaveChanges();
        }

        if (!db.RelatedLinks.Any())
        {
            db.RelatedLinks.AddRange(new []
            {
                new RelatedLink { Title = "وزارت صمت", Url = "https://mimt.gov.ir", Order = 1 },
                new RelatedLink { Title = "بورس کالا", Url = "https://ime.co.ir", Order = 2 }
            });
            db.SaveChanges();
        }
    }
}