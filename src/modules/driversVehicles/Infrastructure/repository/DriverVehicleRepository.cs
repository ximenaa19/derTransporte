using System;
using derTransporte.src.modules.driversVehicles.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.driversVehicles.Infrastructure.repository;

public class DriverVehicleRepository
{
    private readonly AppDbContext _context;
    public DriverVehicleRepository(AppDbContext context)
    {
        _context = context;
    }       

    public async Task<List<DriverVehicleEntity>> GetAllAsync()
        => await _context.DriverVehicle.AsAsyncEnumerable().ToListAsync();

    public async Task<DriverVehicleEntity?> GetByIdAsync(Guid id)
        => await _context.DriverVehicle.FindAsync(id);

    public async Task AddAsync(DriverVehicleEntity entity)
    {
        await _context.DriverVehicle.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(DriverVehicleEntity entity)
    {
        _context.DriverVehicle.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.DriverVehicle.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }   

}
