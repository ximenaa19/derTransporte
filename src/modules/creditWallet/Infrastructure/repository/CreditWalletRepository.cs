using System;
using derTransporte.src.modules.creditWallet.Infrastructure.entity;
using derTransporte.src.shared.context;
using Microsoft.EntityFrameworkCore;

namespace derTransporte.src.modules.creditWallet.Infrastructure.repository;

public class CreditWalletRepository
{
    private readonly AppDbContext _context;

    public CreditWalletRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<CreditWalletEntity>> GetAllAsync()
        => await _context.CreditWallet.ToListAsync();

    public async Task<CreditWalletEntity?> GetByIdAsync(Guid id)
        => await _context.CreditWallet.FindAsync(id);

    public async Task AddAsync(CreditWalletEntity entity)
    {
        await _context.CreditWallet.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(CreditWalletEntity entity)
    {
        _context.CreditWallet.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.CreditWallet.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
