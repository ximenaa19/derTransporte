using System;
using derTransporte.src.modules.companiesStatus.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.companiesStatus.Infrastructure.repository;

public class CompaniesStatusRepository
{
    private readonly AppDbContext _context;
    public CompaniesStatusRepository(AppDbContext context)
    {
        _context = context;
    }    
    public async Task<List<CompaniesStatusEntity>> GetAllAsync()
        => await _context.CompaniesStatus.AsAsyncEnumerable().ToListAsync();

    public async Task<CompaniesStatusEntity?> GetByIdAsync(Guid id)
        => await _context.CompaniesStatus.FindAsync(id);

    public async Task AddAsync(CompaniesStatusEntity entity)
    {
        await _context.CompaniesStatus.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(CompaniesStatusEntity entity)
    {
        _context.CompaniesStatus.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.CompaniesStatus.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
