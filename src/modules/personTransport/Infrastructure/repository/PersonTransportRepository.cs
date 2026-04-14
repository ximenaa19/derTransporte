using System;
using derTransporte.src.modules.personTransport.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.personTransport.Infrastructure.repository;

public class PersonTransportRepository
{
    private readonly AppDbContext _context;
    public PersonTransportRepository(AppDbContext context)
    {
        _context = context;
    }       

    public async Task<List<PersonTransportEntity>> GetAllAsync()
        => await _context.PersonTransport.AsAsyncEnumerable().ToListAsync();

    public async Task<PersonTransportEntity?> GetByIdAsync(Guid id)
        => await _context.PersonTransport.FindAsync(id);

    public async Task AddAsync(PersonTransportEntity entity)
    {
        await _context.PersonTransport.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(PersonTransportEntity entity)
    {
        _context.PersonTransport.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.PersonTransport.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
