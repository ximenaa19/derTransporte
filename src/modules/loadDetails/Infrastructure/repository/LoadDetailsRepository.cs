using System;
using Microsoft.EntityFrameworkCore;
using derTransporte.src.modules.loadDetails.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.loadDetails.Infrastructure.repository;

public class LoadDetailsRepository
{
    private readonly AppDbContext _context;
    public LoadDetailsRepository(AppDbContext context)
    {
        _context = context;
    }       
    public async Task<List<LoadDetailsEntity>> GetAllAsync()
        => await _context.LoadDetails.ToListAsync();    
    public async Task<LoadDetailsEntity?> GetByIdAsync(Guid id) 
        => await _context.LoadDetails.FindAsync(id);
    public async Task AddAsync(LoadDetailsEntity entity)
    {
        await _context.LoadDetails.AddAsync(entity);
        await _context.SaveChangesAsync();
    }
    public async Task UpdateAsync(LoadDetailsEntity entity)
    {
        _context.LoadDetails.Update(entity);
        await _context.SaveChangesAsync();
    }
    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.LoadDetails.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
