using System;
using derTransporte.src.modules.transactionTypes.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.transactionTypes.Infrastructure.repository;

public class TransactionTypeRepository
{
    private readonly AppDbContext _context;
    public TransactionTypeRepository(AppDbContext context)
    {
        _context = context;
    }    
    public async Task<List<TransactionTypeEntity>> GetAllAsync()
        => await _context.TransactionType.AsAsyncEnumerable().ToListAsync();

    public async Task<TransactionTypeEntity?> GetByIdAsync(Guid id)
        => await _context.TransactionType.FindAsync(id);

    public async Task AddAsync(TransactionTypeEntity entity)
    {
        await _context.TransactionType.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(TransactionTypeEntity entity)
    {
        _context.TransactionType.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.TransactionType.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
