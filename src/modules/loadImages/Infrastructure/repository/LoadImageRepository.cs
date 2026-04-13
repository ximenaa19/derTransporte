using System;
using derTransporte.src.modules.loadImages.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.loadImages.Infrastructure.repository;

public class LoadImageRepository
{
    private readonly AppDbContext _context;
    public LoadImageRepository(AppDbContext context)
    {
        _context = context;
    }       

    public async Task<List<LoadImageEntity>> GetAllAsync()
        => await _context.LoadImage.AsAsyncEnumerable().ToListAsync();

    public async Task<LoadImageEntity?> GetByIdAsync(Guid id)
        => await _context.LoadImage.FindAsync(id);

    public async Task AddAsync(LoadImageEntity entity)
    {
        await _context.LoadImage.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(LoadImageEntity entity)
    {
        _context.LoadImage.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.LoadImage.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
