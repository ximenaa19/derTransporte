using System;
using derTransporte.src.modules.companyVehicles.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.companyVehicles.Infrastructure.repository;

public class CompanyVehicleRepository
{
    private readonly AppDbContext _context;
    public CompanyVehicleRepository(AppDbContext context)
    {
        _context = context;
    }       

    public async Task<List<CompanyVehicleEntity>> GetAllAsync()
        => await _context.CompanyVehicle.AsAsyncEnumerable().ToListAsync();

    public async Task<CompanyVehicleEntity?> GetByIdAsync(Guid id)
        => await _context.CompanyVehicle.FindAsync(id);

    public async Task AddAsync(CompanyVehicleEntity entity)
    {
        await _context.CompanyVehicle.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(CompanyVehicleEntity entity)
    {
        _context.CompanyVehicle.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.CompanyVehicle.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
