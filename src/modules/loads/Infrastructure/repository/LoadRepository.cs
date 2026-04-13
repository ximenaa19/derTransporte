using System;
using Microsoft.EntityFrameworkCore;
using derTransporte.src.modules.loads.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.loads.Infrastructure.repository;

public class LoadRepository
{
    private readonly AppDbContext _context;

    public LoadRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<LoadEntity>> GetAllAsync()
        => await _context.Load.ToListAsync();

    public async Task<LoadEntity?> GetByIdAsync(Guid id)
        => await _context.Load.FindAsync(id);

    public async Task AddAsync(LoadEntity entity)
    {
        await _context.Load.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(LoadEntity entity)
    {
        _context.Load.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.Load.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }   

}
