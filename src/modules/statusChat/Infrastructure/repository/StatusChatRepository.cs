using System;
using derTransporte.src.modules.statusChat.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.statusChat.Infrastructure.repository;

public class StatusChatRepository
{
    private readonly AppDbContext _context;
    public StatusChatRepository(AppDbContext context)
    {
        _context = context;
    }    
    public async Task<List<StatusChatEntity>> GetAllAsync()
        => await _context.StatusChat.AsAsyncEnumerable().ToListAsync();

    public async Task<StatusChatEntity?> GetByIdAsync(Guid id)
        => await _context.StatusChat.FindAsync(id);

    public async Task AddAsync(StatusChatEntity entity)
    {
        await _context.StatusChat.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(StatusChatEntity entity)
    {
        _context.StatusChat.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.StatusChat.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
