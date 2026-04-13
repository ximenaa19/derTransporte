using System;
using Microsoft.EntityFrameworkCore;
using derTransporte.src.modules.drivers.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.drivers.Infrastructure.repository;

public class DriverRepository
{
    private readonly AppDbContext _context;

    public DriverRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<DriverEntity>> GetAllAsync()
        => await _context.Driver.ToListAsync();

    public async Task<DriverEntity?> GetByIdAsync(Guid id)
        => await _context.Driver.FindAsync(id);

    public async Task AddAsync(DriverEntity entity)
    {
        await _context.Driver.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(DriverEntity entity)
    {
        _context.Driver.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.Driver.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
