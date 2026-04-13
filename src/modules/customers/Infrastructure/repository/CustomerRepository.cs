using System;
using Microsoft.EntityFrameworkCore;
using derTransporte.src.modules.customers.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.customers.Infrastructure.repository;

public class CustomerRepository
{
    private readonly AppDbContext _context;

    public CustomerRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<CustomerEntity>> GetAllAsync()
        => await _context.Customer.AsAsyncEnumerable().ToListAsync();

    public async Task<CustomerEntity?> GetByIdAsync(Guid id)
        => await _context.Customer.FindAsync(id);

    public async Task AddAsync(CustomerEntity entity)
    {
        await _context.Customer.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(CustomerEntity entity)
    {
        _context.Customer.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.Customer.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
