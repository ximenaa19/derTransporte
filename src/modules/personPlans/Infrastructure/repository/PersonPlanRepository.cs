using System;
using derTransporte.src.modules.personPlans.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.personPlans.Infrastructure.repository;

public class PersonPlanRepository
{
    private readonly AppDbContext _context;
    public PersonPlanRepository(AppDbContext context)
    {
        _context = context;
    }       

    public async Task<List<PersonPlanEntity>> GetAllAsync()
        => await _context.PersonPlan.AsAsyncEnumerable().ToListAsync();

    public async Task<PersonPlanEntity?> GetByIdAsync(Guid id)
        => await _context.PersonPlan.FindAsync(id);

    public async Task AddAsync(PersonPlanEntity entity)
    {
        await _context.PersonPlan.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(PersonPlanEntity entity)
    {
        _context.PersonPlan.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.PersonPlan.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
