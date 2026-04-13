using System;
using derTransporte.src.modules.disputes.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.disputes.Infrastructure.repository;

public class DisputeRepository
{
    private readonly AppDbContext _context;

    public DisputeRepository(AppDbContext context)
    {
        _context = context;
    }       

    public async Task<List<DisputeEntity>> GetAllAsync()
        => await _context.Dispute.AsAsyncEnumerable().ToListAsync();

    public async Task<DisputeEntity?> GetByIdAsync(Guid id)
        => await _context.Dispute.FindAsync(id);

    public async Task AddAsync(DisputeEntity entity)
    {
        await _context.Dispute.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(DisputeEntity entity)
    {
        _context.Dispute.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.Dispute.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
