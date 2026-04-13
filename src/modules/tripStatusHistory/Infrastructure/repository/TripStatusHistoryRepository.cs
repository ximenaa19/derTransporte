using System;
using derTransporte.src.modules.tripStatusHistory.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.tripStatusHistory.Infrastructure.repository;

public class TripStatusHistoryRepository
{
    private readonly AppDbContext _context;
    public TripStatusHistoryRepository(AppDbContext context)
    {
        _context = context;
    }       

    public async Task<List<TripStatusHistoryEntity>> GetAllAsync()
        => await _context.TripStatusHistory.AsAsyncEnumerable().ToListAsync();

    public async Task<TripStatusHistoryEntity?> GetByIdAsync(Guid id)
        => await _context.TripStatusHistory.FindAsync(id);

    public async Task AddAsync(TripStatusHistoryEntity entity)
    {
        await _context.TripStatusHistory.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(TripStatusHistoryEntity entity)
    {
        _context.TripStatusHistory.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.TripStatusHistory.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }


}
