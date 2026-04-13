using System;
using Microsoft.EntityFrameworkCore;
using derTransporte.src.modules.bids.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.bids.Infrastructure.repository;

public class BidRepository
{
    private readonly AppDbContext _context;

    public BidRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<BidEntity>> GetAllAsync()
        => await _context.Bid.ToListAsync();

    public async Task<BidEntity?> GetByIdAsync(Guid id)
        => await _context.Bid.FindAsync(id);

    public async Task AddAsync(BidEntity entity)
    {
        await _context.Bid.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(BidEntity entity)
    {
        _context.Bid.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.Bid.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
