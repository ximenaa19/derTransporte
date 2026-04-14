using System;
using derTransporte.src.modules.personRoles.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.personRoles.Infrastructure.repository;

public class PersonRolesRepository
{
    private readonly AppDbContext _context;
    public PersonRolesRepository(AppDbContext context)
    {
        _context = context;
    }       

    public async Task<List<PersonRolesEntity>> GetAllAsync()
        => await _context.PersonRoles.AsAsyncEnumerable().ToListAsync();

    public async Task<PersonRolesEntity?> GetByIdAsync(Guid id)
        => await _context.PersonRoles.FindAsync(id);

    public async Task AddAsync(PersonRolesEntity entity)
    {
        await _context.PersonRoles.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(PersonRolesEntity entity)
    {
        _context.PersonRoles.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.PersonRoles.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
