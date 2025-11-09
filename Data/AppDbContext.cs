using Microsoft.EntityFrameworkCore;
using SteelCompany.Api.Models;

namespace SteelCompany.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Page> Pages => Set<Page>();
    public DbSet<News> News => Set<News>();
    public DbSet<Product> Products => Set<Product>();
    public DbSet<Client> Clients => Set<Client>();
    public DbSet<RelatedLink> RelatedLinks => Set<RelatedLink>();
}