using System;
using derTransporte.src.modules.travelScale.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.travelScale.Infrastructure.repository;

public class TravelScaleRepository
{
    private readonly AppDbContext _context;
    public TravelScaleRepository(AppDbContext context)
    {
        _context = context;
    }       

    public async Task<List<TravelScaleEntity>> GetAllAsync()
        => await _context.TravelScale.AsAsyncEnumerable().ToListAsync();

    public async Task<TravelScaleEntity?> GetByIdAsync(Guid id)
        => await _context.TravelScale.FindAsync(id);

    public async Task AddAsync(TravelScaleEntity entity)
    {
        await _context.TravelScale.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(TravelScaleEntity entity)
    {
        _context.TravelScale.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.TravelScale.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
