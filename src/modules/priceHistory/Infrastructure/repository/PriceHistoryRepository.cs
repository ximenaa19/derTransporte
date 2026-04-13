using System;
using derTransporte.src.modules.priceHistory.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.priceHistory.Infrastructure.repository;

public class PriceHistoryRepository
{
    private readonly AppDbContext _context;
    public PriceHistoryRepository(AppDbContext context)
    {
        _context = context;
    }       

    public async Task<List<PriceHistoryEntity>> GetAllAsync()
        => await _context.PriceHistory.AsAsyncEnumerable().ToListAsync();

    public async Task<PriceHistoryEntity?> GetByIdAsync(Guid id)
        => await _context.PriceHistory.FindAsync(id);

    public async Task AddAsync(PriceHistoryEntity entity)
    {
        await _context.PriceHistory.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(PriceHistoryEntity entity)
    {
        _context.PriceHistory.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.PriceHistory.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
