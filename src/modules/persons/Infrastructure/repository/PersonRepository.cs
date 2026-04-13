using System;
using Microsoft.EntityFrameworkCore;
using derTransporte.src.modules.persons.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.persons.Infrastructure.repository;

public class PersonRepository
{
    private readonly AppDbContext _context;

    public PersonRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<PersonEntity>> GetAllAsync()
        => await _context.Person.ToListAsync();

    public async Task<PersonEntity?> GetByIdAsync(Guid id)
        => await _context.Person.FindAsync(id);

    public async Task AddAsync(PersonEntity entity)
    {
        await _context.Person.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(PersonEntity entity)
    {
        _context.Person.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.Person.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
