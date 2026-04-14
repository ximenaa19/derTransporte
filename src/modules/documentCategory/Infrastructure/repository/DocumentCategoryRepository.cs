using System;
using derTransporte.src.modules.documentCategory.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.documentCategory.Infrastructure.repository;

public class DocumentCategoryRepository
{
    private readonly AppDbContext _context;
    public DocumentCategoryRepository(AppDbContext context)
    {
        _context = context;
    }    
    public async Task<List<DocumentCategoryEntity>> GetAllAsync()
        => await _context.DocumentCategory.AsAsyncEnumerable().ToListAsync();

    public async Task<DocumentCategoryEntity?> GetByIdAsync(Guid id)
        => await _context.DocumentCategory.FindAsync(id);

    public async Task AddAsync(DocumentCategoryEntity entity)
    {
        await _context.DocumentCategory.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(DocumentCategoryEntity entity)
    {
        _context.DocumentCategory.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.DocumentCategory.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
