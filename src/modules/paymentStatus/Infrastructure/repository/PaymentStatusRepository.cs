using System;
using derTransporte.src.modules.paymentStatus.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.paymentStatus.Infrastructure.repository;

public class PaymentStatusRepository
{
    private readonly AppDbContext _context;
    public PaymentStatusRepository(AppDbContext context)
    {
        _context = context;
    }    
    public async Task<List<PaymentStatusEntity>> GetAllAsync()
        => await _context.PaymentStatus.AsAsyncEnumerable().ToListAsync();

    public async Task<PaymentStatusEntity?> GetByIdAsync(Guid id)
        => await _context.PaymentStatus.FindAsync(id);

    public async Task AddAsync(PaymentStatusEntity entity)
    {
        await _context.PaymentStatus.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(PaymentStatusEntity entity)
    {
        _context.PaymentStatus.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.PaymentStatus.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
