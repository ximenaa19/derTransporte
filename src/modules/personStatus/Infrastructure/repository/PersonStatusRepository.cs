using System;
using derTransporte.src.modules.personStatus.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.personStatus.Infrastructure.repository;

public class PersonStatusRepository
{
    private readonly AppDbContext _context;
    public PersonStatusRepository(AppDbContext context)
    {
        _context = context;
    }    
    public async Task<List<PersonStatusEntity>> GetAllAsync()
        => await _context.PersonStatus.AsAsyncEnumerable().ToListAsync();

    public async Task<PersonStatusEntity?> GetByIdAsync(Guid id)
        => await _context.PersonStatus.FindAsync(id);

    public async Task AddAsync(PersonStatusEntity entity)
    {
        await _context.PersonStatus.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(PersonStatusEntity entity)
    {
        _context.PersonStatus.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.PersonStatus.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
