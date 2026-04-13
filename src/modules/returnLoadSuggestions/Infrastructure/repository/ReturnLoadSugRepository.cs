using System;
using derTransporte.src.modules.returnLoadSuggestions.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.returnLoadSuggestions.Infrastructure.repository;

public class ReturnLoadSugRepository
{
    private readonly AppDbContext _context;
    public ReturnLoadSugRepository(AppDbContext context)
    {
        _context = context;
    }       

    public async Task<List<ReturnLoadSugEntity>> GetAllAsync()
        => await _context.ReturnLoadSug.AsAsyncEnumerable().ToListAsync();

    public async Task<ReturnLoadSugEntity?> GetByIdAsync(Guid id)
        => await _context.ReturnLoadSug.FindAsync(id);

    public async Task AddAsync(ReturnLoadSugEntity entity)
    {
        await _context.ReturnLoadSug.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(ReturnLoadSugEntity entity)
    {
        _context.ReturnLoadSug.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.ReturnLoadSug.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
