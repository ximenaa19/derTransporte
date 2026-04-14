using System;
using derTransporte.src.modules.typeVehicles.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.typeVehicles.Infrastructure.repository;

public class TypeVehicleRepository
{
    private readonly AppDbContext _context;
    public TypeVehicleRepository(AppDbContext context)
    {
        _context = context;
    }    
    public async Task<List<TypeVehicleEntity>> GetAllAsync()
        => await _context.TypeVehicle.AsAsyncEnumerable().ToListAsync();

    public async Task<TypeVehicleEntity?> GetByIdAsync(Guid id)
        => await _context.TypeVehicle.FindAsync(id);

    public async Task AddAsync(TypeVehicleEntity entity)
    {
        await _context.TypeVehicle.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(TypeVehicleEntity entity)
    {
        _context.TypeVehicle.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.TypeVehicle.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
