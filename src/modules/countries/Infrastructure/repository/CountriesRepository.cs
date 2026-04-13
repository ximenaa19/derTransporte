using derTransporte.src.modules.countries.Infrastructure.entity;
using derTransporte.src.shared.context;
using Microsoft.EntityFrameworkCore;

namespace derTransporte.src.modules.countries.Infrastructure.repository;

public class CountriesRepository
{
    private readonly AppDbContext _context;

    public CountriesRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<CountriesEntity>> GetAllAsync()
        => await _context.countries.ToListAsync();

    public async Task<CountriesEntity?> GetByIdAsync(Guid id)
        => await _context.countries.FindAsync(id);

    public async Task AddAsync(CountriesEntity entity)
    {
        await _context.countries.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(CountriesEntity entity)
    {
        _context.countries.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.countries.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}