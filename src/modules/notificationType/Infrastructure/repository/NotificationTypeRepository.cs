using System;
using derTransporte.src.modules.notificationType.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.notificationType.Infrastructure.repository;

public class NotificationTypeRepository
{
    private readonly AppDbContext _context;
    public NotificationTypeRepository(AppDbContext context)
    {
        _context = context;
    }    
    public async Task<List<NotificationTypeEntity>> GetAllAsync()
        => await _context.NotificationType.AsAsyncEnumerable().ToListAsync();

    public async Task<NotificationTypeEntity?> GetByIdAsync(Guid id)
        => await _context.NotificationType.FindAsync(id);

    public async Task AddAsync(NotificationTypeEntity entity)
    {
        await _context.NotificationType.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(NotificationTypeEntity entity)
    {
        _context.NotificationType.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.NotificationType.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
