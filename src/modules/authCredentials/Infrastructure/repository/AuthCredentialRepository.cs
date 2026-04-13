using System;
using Microsoft.EntityFrameworkCore;
using derTransporte.src.modules.authCredentials.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.authCredentials.Infrastructure.repository;

public class AuthCredentialRepository
{
    private readonly AppDbContext _context;

    public AuthCredentialRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<AuthCredentialEntity>> GetAllAsync()
        => await _context.AuthCredential.ToListAsync();

    public async Task<AuthCredentialEntity?> GetByIdAsync(Guid id)
        => await _context.AuthCredential.FindAsync(id);

    public async Task AddAsync(AuthCredentialEntity entity)
    {
        await _context.AuthCredential.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(AuthCredentialEntity entity)
    {
        _context.AuthCredential.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.AuthCredential.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }       

}
