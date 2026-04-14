using System;
using derTransporte.src.modules.assigmentRole.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.assigmentRole.Infrastructure.repository;

public class AssigmentRoleRepository
{
    private readonly AppDbContext _context;
    public AssigmentRoleRepository(AppDbContext context)
    {
        _context = context;
    }    
    public async Task<List<AssigmentRoleEntity>> GetAllAsync()
        => await _context.AssigmentRole.AsAsyncEnumerable().ToListAsync();

    public async Task<AssigmentRoleEntity?> GetByIdAsync(Guid id)
        => await _context.AssigmentRole.FindAsync(id);

    public async Task AddAsync(AssigmentRoleEntity entity)
    {
        await _context.AssigmentRole.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(AssigmentRoleEntity entity)
    {
        _context.AssigmentRole.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.AssigmentRole.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
