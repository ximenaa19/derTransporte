using System;
using derTransporte.src.modules.loadStatusHistory.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.loadStatusHistory.Infrastructure.repository;

public class LoadStatusHistoryRepository
{
    private readonly AppDbContext _context;
    public LoadStatusHistoryRepository(AppDbContext context)
    {
        _context = context;
    }       

    public async Task<List<LoadStatusHistoryEntity>> GetAllAsync()
        => await _context.LoadStatusHistory.AsAsyncEnumerable().ToListAsync();

    public async Task<LoadStatusHistoryEntity?> GetByIdAsync(Guid id)
        => await _context.LoadStatusHistory.FindAsync(id);

    public async Task AddAsync(LoadStatusHistoryEntity entity)
    {
        await _context.LoadStatusHistory.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(LoadStatusHistoryEntity entity)
    {
        _context.LoadStatusHistory.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.LoadStatusHistory.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
