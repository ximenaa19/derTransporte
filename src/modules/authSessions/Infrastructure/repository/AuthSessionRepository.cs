using System;
using derTransporte.src.modules.authSessions.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.auditLog.Infrastructure.repository;

public class AuthSessionRepository
{
    private readonly AppDbContext _context;

    public AuthSessionRepository(AppDbContext context)
    {
        _context = context;
    }       

    public async Task<List<AuthSessionEntity>> GetAllAsync()
        => await _context.AuthSession.AsAsyncEnumerable().ToListAsync();

    public async Task<AuthSessionEntity?> GetByIdAsync(Guid id)
        => await _context.AuthSession.FindAsync(id);

    public async Task AddAsync(AuthSessionEntity entity)
    {
        await _context.AuthSession.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(AuthSessionEntity entity)
    {
        _context.AuthSession.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.AuthSession.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
