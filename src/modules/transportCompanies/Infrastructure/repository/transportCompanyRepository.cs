using System;
using Microsoft.EntityFrameworkCore;
using derTransporte.src.modules.transportCompanies.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.transportCompanies.Infrastructure.repository;

public class transportCompanyRepository
{
    private readonly AppDbContext _context;

    public transportCompanyRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<transportCompanyEntity>> GetAllAsync()
        => await _context.transportCompany.ToListAsync();

    public async Task<transportCompanyEntity?> GetByIdAsync(Guid id)
        => await _context.transportCompany.FindAsync(id);

    public async Task AddAsync(transportCompanyEntity entity)
    {
        await _context.transportCompany.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(transportCompanyEntity entity)
    {
        _context.transportCompany.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.transportCompany.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }   
    


}
