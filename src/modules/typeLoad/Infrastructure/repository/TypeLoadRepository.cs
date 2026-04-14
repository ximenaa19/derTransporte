using System;
using derTransporte.src.modules.typeLoad.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.typeLoad.Infrastructure.repository;

public class TypeLoadRepository
{
    private readonly AppDbContext _context;
    public TypeLoadRepository(AppDbContext context)
    {
        _context = context;
    }       
    public async Task<List<TypeLoadEntity>> GetAllAsync()
        => await _context.TypeLoad.AsAsyncEnumerable().ToListAsync();

    public async Task<TypeLoadEntity?> GetByIdAsync(Guid id)
        => await _context.TypeLoad.FindAsync(id);

    public async Task AddAsync(TypeLoadEntity entity)
    {
        await _context.TypeLoad.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(TypeLoadEntity entity)
    {
        _context.TypeLoad.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.TypeLoad.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
