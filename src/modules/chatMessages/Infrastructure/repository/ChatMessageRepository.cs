using System;
using derTransporte.src.modules.chatMessages.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.chatMessages.Infrastructure.repository;

public class ChatMessageRepository
{
    private readonly AppDbContext _context;
    public ChatMessageRepository(AppDbContext context)
    {
        _context = context;
    }       

    public async Task<List<ChatMessageEntity>> GetAllAsync()
        => await _context.ChatMessage.AsAsyncEnumerable().ToListAsync();

    public async Task<ChatMessageEntity?> GetByIdAsync(Guid id)
        => await _context.ChatMessage.FindAsync(id);

    public async Task AddAsync(ChatMessageEntity entity)
    {
        await _context.ChatMessage.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(ChatMessageEntity entity)
    {
        _context.ChatMessage.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.ChatMessage.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
