using System;
using derTransporte.src.modules.auditLog.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.auditLog.Infrastructure.repository;

public class AuditLogRepository
{
    private readonly AppDbContext _context;

    public AuditLogRepository(AppDbContext context)
    {
        _context = context;
    }       

    public async Task<List<AuditLogEntity>> GetAllAsync()
        => await _context.AuditLog.AsAsyncEnumerable().ToListAsync();

    public async Task<AuditLogEntity?> GetByIdAsync(Guid id)
        => await _context.AuditLog.FindAsync(id);

    public async Task AddAsync(AuditLogEntity entity)
    {
        await _context.AuditLog.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(AuditLogEntity entity)
    {
        _context.AuditLog.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.AuditLog.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
