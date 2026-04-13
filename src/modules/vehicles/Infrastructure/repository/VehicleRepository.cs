using Microsoft.EntityFrameworkCore;
using derTransporte.src.modules.vehicles.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.vehicles.Infrastructure.repository;

public class VehicleRepository
{
    private readonly AppDbContext _context;

    public VehicleRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<VehicleEntity>> GetAllAsync()
        => await _context.Vehicle.ToListAsync();

    public async Task<VehicleEntity?> GetByIdAsync(Guid id)
        => await _context.Vehicle.FindAsync(id);

    public async Task AddAsync(VehicleEntity entity)
    {
        await _context.Vehicle.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(VehicleEntity entity)
    {
        _context.Vehicle.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.Vehicle.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }   


}
