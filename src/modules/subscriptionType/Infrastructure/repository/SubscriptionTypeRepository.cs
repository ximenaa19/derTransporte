using System;
using derTransporte.src.modules.subscriptionType.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.subscriptionType.Infrastructure.repository;

public class SubscriptionTypeRepository
{
    private readonly AppDbContext _context;
    public SubscriptionTypeRepository(AppDbContext context)
    {
        _context = context;
    }    
    public async Task<List<SubscriptionTypeEntity>> GetAllAsync()
        => await _context.SubscriptionType.AsAsyncEnumerable().ToListAsync();

    public async Task<SubscriptionTypeEntity?> GetByIdAsync(Guid id)
        => await _context.SubscriptionType.FindAsync(id);

    public async Task AddAsync(SubscriptionTypeEntity entity)
    {
        await _context.SubscriptionType.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(SubscriptionTypeEntity entity)
    {
        _context.SubscriptionType.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.SubscriptionType.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
