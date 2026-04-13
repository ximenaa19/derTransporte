using System;
using derTransporte.src.modules.documentDrivers.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.documentDrivers.Infrastructure.repository;

public class DocumentDriverRepository
{
    private readonly AppDbContext _context;
    public DocumentDriverRepository(AppDbContext context)
    {
        _context = context;
    }       

    public async Task<List<DocumentDriverEntity>> GetAllAsync()
        => await _context.DocumentDriver.AsAsyncEnumerable().ToListAsync();

    public async Task<DocumentDriverEntity?> GetByIdAsync(Guid id)
        => await _context.DocumentDriver.FindAsync(id);

    public async Task AddAsync(DocumentDriverEntity entity)
    {
        await _context.DocumentDriver.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(DocumentDriverEntity entity)
    {
        _context.DocumentDriver.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.DocumentDriver.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
