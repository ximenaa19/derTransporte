using System;
using derTransporte.src.modules.reasonDisputes.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.reasonDisputes.Infrastructure.repository;

public class ReasonDisputeRepository
{
    private readonly AppDbContext _context;
    public ReasonDisputeRepository(AppDbContext context)
    {
        _context = context;
    }    
    public async Task<List<ReasonDisputeEntity>> GetAllAsync()
        => await _context.ReasonDispute.AsAsyncEnumerable().ToListAsync();

    public async Task<ReasonDisputeEntity?> GetByIdAsync(Guid id)
        => await _context.ReasonDispute.FindAsync(id);

    public async Task AddAsync(ReasonDisputeEntity entity)
    {
        await _context.ReasonDispute.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(ReasonDisputeEntity entity)
    {
        _context.ReasonDispute.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.ReasonDispute.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
