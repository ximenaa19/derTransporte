using System;
using derTransporte.src.modules.roles.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.roles.Infrastructure.repository;

public class RoleRepository
{
    private readonly AppDbContext _context;
    public RoleRepository(AppDbContext context)
    {
        _context = context;
    }    
    public async Task<List<RoleEntity>> GetAllAsync()
        => await _context.Role.AsAsyncEnumerable().ToListAsync();

    public async Task<RoleEntity?> GetByIdAsync(Guid id)
        => await _context.Role.FindAsync(id);

    public async Task AddAsync(RoleEntity entity)
    {
        await _context.Role.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(RoleEntity entity)
    {
        _context.Role.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.Role.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
