using System;
using derTransporte.src.modules.subscriptions.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.subscriptions.Infrastructure.repository;

public class SubscriptionRepository
{
    private readonly AppDbContext _context;
    public SubscriptionRepository(AppDbContext context)
    {
        _context = context;
    }       

    public async Task<List<SubscriptionEntity>> GetAllAsync()
        => await _context.Subscription.AsAsyncEnumerable().ToListAsync();

    public async Task<SubscriptionEntity?> GetByIdAsync(Guid id)
        => await _context.Subscription.FindAsync(id);

    public async Task AddAsync(SubscriptionEntity entity)
    {
        await _context.Subscription.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(SubscriptionEntity entity)
    {
        _context.Subscription.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.Subscription.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
