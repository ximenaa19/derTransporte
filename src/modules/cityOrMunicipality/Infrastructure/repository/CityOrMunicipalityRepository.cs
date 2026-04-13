using System;
using derTransporte.src.modules.cityOrMunicipality.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.cityOrMunicipality.Infrastructure.repository;

public class CityOrMunicipalityRepository
{
    private readonly AppDbContext _context;

    public CityOrMunicipalityRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<CityOrMunicipalityEntity>> GetAllAsync()
        => await _context.CityOrMunicipality.AsAsyncEnumerable().ToListAsync();

    public async Task<CityOrMunicipalityEntity?> GetByIdAsync(Guid id)
        => await _context.CityOrMunicipality.FindAsync(id);

    public async Task AddAsync(CityOrMunicipalityEntity entity)
    {
        await _context.CityOrMunicipality.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(CityOrMunicipalityEntity entity)
    {
        _context.CityOrMunicipality.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.CityOrMunicipality.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }   

}
