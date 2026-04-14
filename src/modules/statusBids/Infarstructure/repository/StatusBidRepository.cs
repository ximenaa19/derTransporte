using System;
using derTransporte.src.modules.statusBids.Infarstructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.statusBids.Infarstructure.repository;

public class StatusBidRepository
{
    private readonly AppDbContext _context;
    public StatusBidRepository(AppDbContext context)
    {
        _context = context;
    }    
    public async Task<List<StatusBidEntity>> GetAllAsync()
        => await _context.StatusBid.AsAsyncEnumerable().ToListAsync();

    public async Task<StatusBidEntity?> GetByIdAsync(Guid id)
        => await _context.StatusBid.FindAsync(id);

    public async Task AddAsync(StatusBidEntity entity)
    {
        await _context.StatusBid.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(StatusBidEntity entity)
    {
        _context.StatusBid.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.StatusBid.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
