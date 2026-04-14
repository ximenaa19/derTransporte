using System;
using derTransporte.src.modules.documentsStatus.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.documentsStatus.Infrastructure.repository;

public class DocumentsStatusRepository
{
    private readonly AppDbContext _context;
    public DocumentsStatusRepository(AppDbContext context)
    {
        _context = context;
    }    
    public async Task<List<DocumentsStatusEntity>> GetAllAsync()
        => await _context.DocumentsStatus.AsAsyncEnumerable().ToListAsync();

    public async Task<DocumentsStatusEntity?> GetByIdAsync(Guid id)
        => await _context.DocumentsStatus.FindAsync(id);

    public async Task AddAsync(DocumentsStatusEntity entity)
    {
        await _context.DocumentsStatus.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(DocumentsStatusEntity entity)
    {
        _context.DocumentsStatus.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.DocumentsStatus.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
