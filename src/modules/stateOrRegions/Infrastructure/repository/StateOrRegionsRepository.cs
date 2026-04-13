using System;
using Microsoft.EntityFrameworkCore;
using derTransporte.src.modules.stateOrRegions.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.stateOrRegions.Infrastructure.repository;

public class StateOrRegionsRepository
{
    private readonly AppDbContext _context;

    public StateOrRegionsRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<StateOrRegionsEntity>> GetAllAsync()
        => await _context.StateOrRegions.ToListAsync();

    public async Task<StateOrRegionsEntity?> GetByIdAsync(Guid id)
        => await _context.StateOrRegions.FindAsync(id);

    public async Task AddAsync(StateOrRegionsEntity entity)
    {
        await _context.StateOrRegions.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(StateOrRegionsEntity entity)
    {
        _context.StateOrRegions.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.StateOrRegions.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
