using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using derTransporte.src.modules.trips.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.trips.Infrastructure.repository;

public class TripRepository
{
    private readonly AppDbContext _context;

    public TripRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<TripEntity>> GetAllAsync()
        => await _context.Trip.ToListAsync();

    public async Task<TripEntity?> GetByIdAsync(Guid id)
        => await _context.Trip.FindAsync(id);

    public async Task AddAsync(TripEntity entity)
    {
        await _context.Trip.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(TripEntity entity)
    {
        _context.Trip.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.Trip.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }   

}
