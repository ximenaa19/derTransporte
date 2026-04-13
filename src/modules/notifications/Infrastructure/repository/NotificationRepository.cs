using System;
using derTransporte.src.modules.notifications.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.notifications.Infrastructure.repository;

public class NotificationRepository
{
    private readonly AppDbContext _context;

    public NotificationRepository(AppDbContext context)
    {
        _context = context;
    }       

    public async Task<List<NotificationEntity>> GetAllAsync()
        => await _context.Notification.AsAsyncEnumerable().ToListAsync();

    public async Task<NotificationEntity?> GetByIdAsync(Guid id)
        => await _context.Notification.FindAsync(id);

    public async Task AddAsync(NotificationEntity entity)
    {
        await _context.Notification.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(NotificationEntity entity)
    {
        _context.Notification.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.Notification.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
