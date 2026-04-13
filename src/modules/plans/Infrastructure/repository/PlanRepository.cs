using System;
using Microsoft.EntityFrameworkCore;
using derTransporte.src.modules.plans.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.plans.Infrastructure.repository;

public class PlanRepository
{
    private readonly AppDbContext _context;

    public PlanRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<PlanEntity>> GetAllAsync()
        => await _context.Plan.ToListAsync();

    public async Task<PlanEntity?> GetByIdAsync(Guid id)
        => await _context.Plan.FindAsync(id);

    public async Task AddAsync(PlanEntity entity)
    {
        await _context.Plan.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(PlanEntity entity)
    {
        _context.Plan.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.Plan.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
