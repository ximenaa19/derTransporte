using System;
using Microsoft.EntityFrameworkCore;
using derTransporte.src.modules.payments.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.payments.Infrastructure.repository;

public class PaymentRepository
{
    private readonly AppDbContext _context;

    public PaymentRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<PaymentEntity>> GetAllAsync()
        => await _context.Payment.ToListAsync();

    public async Task<PaymentEntity?> GetByIdAsync(Guid id)
        => await _context.Payment.FindAsync(id);

    public async Task AddAsync(PaymentEntity entity)
    {
        await _context.Payment.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(PaymentEntity entity)
    {
        _context.Payment.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.Payment.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
