using System;
using derTransporte.src.modules.companyDocuments.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.companyDocuments.Infrastructure.repository;

public class CompanyDocumentRepository
{
    private readonly AppDbContext _context;
    public CompanyDocumentRepository(AppDbContext context)
    {
        _context = context;
    }
        public async Task<List<CompanyDocumentEntity>> GetAllAsync()
        => await _context.CompanyDocument.AsAsyncEnumerable().ToListAsync();        
        public async Task<CompanyDocumentEntity?> GetByIdAsync(Guid id)
        => await _context.CompanyDocument.FindAsync(id);
        public async Task AddAsync(CompanyDocumentEntity entity)
        {
            await _context.CompanyDocument.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(CompanyDocumentEntity entity)
        {
            _context.CompanyDocument.Update(entity);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _context.CompanyDocument.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

}
