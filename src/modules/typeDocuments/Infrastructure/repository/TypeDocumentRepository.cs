using System;
using derTransporte.src.modules.typeDocuments.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.typeDocuments.Infrastructure.repository;

public class TypeDocumentRepository
{
    private readonly AppDbContext _context;
    public TypeDocumentRepository(AppDbContext context)
    {
        _context = context;
    }    
    public async Task<List<TypeDocumentEntity>> GetAllAsync()
        => await _context.TypeDocument.AsAsyncEnumerable().ToListAsync();

    public async Task<TypeDocumentEntity?> GetByIdAsync(Guid id)
        => await _context.TypeDocument.FindAsync(id);

    public async Task AddAsync(TypeDocumentEntity entity)
    {
        await _context.TypeDocument.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(TypeDocumentEntity entity)
    {
        _context.TypeDocument.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.TypeDocument.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
