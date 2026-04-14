using System;
using derTransporte.src.modules.tripAssigments.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.tripAssigments.Infrastructure.repository;

public class TripAssigmentsRepository
{
    private readonly AppDbContext _context;
    public TripAssigmentsRepository(AppDbContext context)
    {
        _context = context;
    }       

    public async Task<List<TripAssigmentsEntity>> GetAllAsync()
        => await _context.TripAssigments.AsAsyncEnumerable().ToListAsync();

    public async Task<TripAssigmentsEntity?> GetByIdAsync(Guid id)
        => await _context.TripAssigments.FindAsync(id);

    public async Task AddAsync(TripAssigmentsEntity entity)
    {
        await _context.TripAssigments.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(TripAssigmentsEntity entity)
    {
        _context.TripAssigments.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.TripAssigments.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
