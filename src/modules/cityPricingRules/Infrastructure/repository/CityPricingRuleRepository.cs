using System;
using derTransporte.src.modules.cityPricingRules.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.cityPricingRules.Infrastructure.repository;

public class CityPricingRuleRepository
{
    private readonly AppDbContext _context;
    public CityPricingRuleRepository(AppDbContext context)
    {
        _context = context;
    }       

    public async Task<List<CityPricingRuleEntity>> GetAllAsync()
        => await _context.CityPricingRule.AsAsyncEnumerable().ToListAsync();

    public async Task<CityPricingRuleEntity?> GetByIdAsync(Guid id)
        => await _context.CityPricingRule.FindAsync(id);

    public async Task AddAsync(CityPricingRuleEntity entity)
    {
        await _context.CityPricingRule.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(CityPricingRuleEntity entity)
    {
        _context.CityPricingRule.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.CityPricingRule.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
