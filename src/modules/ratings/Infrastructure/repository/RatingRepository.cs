using System;
using derTransporte.src.modules.ratings.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.ratings.Infrastructure.repository;

public class RatingRepository
{
    private readonly AppDbContext _context;

    public RatingRepository(AppDbContext context)
    {
        _context = context;
    }       

    public async Task<List<RatingEntity>> GetAllAsync()
        => await _context.Rating.AsAsyncEnumerable().ToListAsync();

    public async Task<RatingEntity?> GetByIdAsync(Guid id)
        => await _context.Rating.FindAsync(id);

    public async Task AddAsync(RatingEntity entity)
    {
        await _context.Rating.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(RatingEntity entity)
    {
        _context.Rating.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.Rating.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
