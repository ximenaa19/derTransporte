using System;
using derTransporte.src.modules.documentCustomers.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.documentCustomers.Infrastructure.repository;

public class DocumentCustomerRepository
{
    private readonly AppDbContext _context;
    public DocumentCustomerRepository(AppDbContext context)
    {
        _context = context;
    }       

    public async Task<List<DocumentCustomerEntity>> GetAllAsync()
        => await _context.DocumentCustomer.AsAsyncEnumerable().ToListAsync();

    public async Task<DocumentCustomerEntity?> GetByIdAsync(Guid id)
        => await _context.DocumentCustomer.FindAsync(id);

    public async Task AddAsync(DocumentCustomerEntity entity)
    {
        await _context.DocumentCustomer.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(DocumentCustomerEntity entity)
    {
        _context.DocumentCustomer.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.DocumentCustomer.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
