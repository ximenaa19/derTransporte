using System;
using derTransporte.src.modules.disputesStatus.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.disputesStatus.Infrastructure.repository;

public class DisputesStatusRepository
{
    private readonly AppDbContext _context;
    public DisputesStatusRepository(AppDbContext context)
    {
        _context = context;
    }    
    public async Task<List<DisputesStatusEntity>> GetAllAsync()
        => await _context.DisputesStatus.AsAsyncEnumerable().ToListAsync();

    public async Task<DisputesStatusEntity?> GetByIdAsync(Guid id)
        => await _context.DisputesStatus.FindAsync(id);

    public async Task AddAsync(DisputesStatusEntity entity)
    {
        await _context.DisputesStatus.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(DisputesStatusEntity entity)
    {
        _context.DisputesStatus.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.DisputesStatus.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
