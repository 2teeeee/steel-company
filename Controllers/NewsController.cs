using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SteelCompany.Api.Data;
using SteelCompany.Api.Models;

namespace SteelCompany.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NewsController : ControllerBase
{
    private readonly AppDbContext _db;
    public NewsController(AppDbContext db) => _db = db;

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] string? lang)
    {
        var q = _db.News.AsQueryable();
        if (!string.IsNullOrEmpty(lang)) q = q.Where(n => n.Language == lang);
        var list = await q.OrderByDescending(n => n.PublishedAt).ToListAsync();
        return Ok(list);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var item = await _db.News.FindAsync(id);
        if (item == null) return NotFound();
        return Ok(item);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] News news)
    {
        _db.News.Add(news);
        await _db.SaveChangesAsync();
        return CreatedAtAction(nameof(Get), new { id = news.Id }, news);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] News news)
    {
        if (id != news.Id) return BadRequest();
        _db.Entry(news).State = EntityState.Modified;
        await _db.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var item = await _db.News.FindAsync(id);
        if (item == null) return NotFound();
        _db.News.Remove(item);
        await _db.SaveChangesAsync();
        return NoContent();
    }
}