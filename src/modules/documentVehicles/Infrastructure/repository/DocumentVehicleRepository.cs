using System;
using derTransporte.src.modules.documentVehicles.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.documentVehicles.Infrastructure.repository;

public class DocumentVehicleRepository
{
    private readonly AppDbContext _context;
    public DocumentVehicleRepository(AppDbContext context)
    {
        _context = context;
    }       

    public async Task<List<DocumentVehicleEntity>> GetAllAsync()
        => await _context.DocumentVehicle.AsAsyncEnumerable().ToListAsync();

    public async Task<DocumentVehicleEntity?> GetByIdAsync(Guid id)
        => await _context.DocumentVehicle.FindAsync(id);

    public async Task AddAsync(DocumentVehicleEntity entity)
    {
        await _context.DocumentVehicle.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(DocumentVehicleEntity entity)
    {
        _context.DocumentVehicle.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.DocumentVehicle.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
