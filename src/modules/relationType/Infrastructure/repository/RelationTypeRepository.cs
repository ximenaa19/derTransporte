using System;
using derTransporte.src.modules.relationType.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.relationType.Infrastructure.repository;

public class RelationTypeRepository
{
    private readonly AppDbContext _context;
    public RelationTypeRepository(AppDbContext context)
    {
        _context = context;
    }    
    public async Task<List<RelationTypeEntity>> GetAllAsync()
        => await _context.RelationType.AsAsyncEnumerable().ToListAsync();

    public async Task<RelationTypeEntity?> GetByIdAsync(Guid id)
        => await _context.RelationType.FindAsync(id);

    public async Task AddAsync(RelationTypeEntity entity)
    {
        await _context.RelationType.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(RelationTypeEntity entity)
    {
        _context.RelationType.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.RelationType.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
