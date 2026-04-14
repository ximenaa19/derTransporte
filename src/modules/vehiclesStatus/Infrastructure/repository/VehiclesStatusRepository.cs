using System;
using derTransporte.src.modules.vehiclesStatus.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.vehiclesStatus.Infrastructure.repository;

public class VehiclesStatusRepository
{
    private readonly AppDbContext _context;
    public VehiclesStatusRepository(AppDbContext context)
    {
        _context = context;
    }    
    public async Task<List<VehiclesStatusEntity>> GetAllAsync()
        => await _context.VehiclesStatus.AsAsyncEnumerable().ToListAsync();

    public async Task<VehiclesStatusEntity?> GetByIdAsync(Guid id)
        => await _context.VehiclesStatus.FindAsync(id);

    public async Task AddAsync(VehiclesStatusEntity entity)
    {
        await _context.VehiclesStatus.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(VehiclesStatusEntity entity)
    {
        _context.VehiclesStatus.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.VehiclesStatus.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
