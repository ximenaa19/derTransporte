using System;
using derTransporte.src.modules.paymentProviders.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.paymentProviders.Infrastructure.repository;

public class PaymentProviderRepository
{
    private readonly AppDbContext _context;
    public PaymentProviderRepository(AppDbContext context)
    {
        _context = context;
    }    
    public async Task<List<PaymentProviderEntity>> GetAllAsync()
        => await _context.PaymentProvider.AsAsyncEnumerable().ToListAsync();

    public async Task<PaymentProviderEntity?> GetByIdAsync(Guid id)
        => await _context.PaymentProvider.FindAsync(id);

    public async Task AddAsync(PaymentProviderEntity entity)
    {
        await _context.PaymentProvider.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(PaymentProviderEntity entity)
    {
        _context.PaymentProvider.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.PaymentProvider.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
