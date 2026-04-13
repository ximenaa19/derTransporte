using System;
using derTransporte.src.modules.creditTransactions.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.creditTransactions.Infrastructure.repository;

public class CreditTransactionRepository
{
    private readonly AppDbContext _context;
    public CreditTransactionRepository(AppDbContext context)
    {
        _context = context;
    }       

    public async Task<List<CreditTransactionEntity>> GetAllAsync()
        => await _context.CreditTransaction.AsAsyncEnumerable().ToListAsync();

    public async Task<CreditTransactionEntity?> GetByIdAsync(Guid id)
        => await _context.CreditTransaction.FindAsync(id);

    public async Task AddAsync(CreditTransactionEntity entity)
    {
        await _context.CreditTransaction.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(CreditTransactionEntity entity)
    {
        _context.CreditTransaction.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.CreditTransaction.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
