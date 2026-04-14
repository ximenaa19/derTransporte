using System;
using derTransporte.src.modules.chatParticipants.Infrastructure.entity;
using derTransporte.src.shared.context;

namespace derTransporte.src.modules.chatParticipants.Infrastructure.repository;

public class ChatParticipantRepository
{
    private readonly AppDbContext _context;
    public ChatParticipantRepository(AppDbContext context)
    {
        _context = context;
    }       

    public async Task<List<ChatParticipantEntity>> GetAllAsync()
        => await _context.ChatParticipant.AsAsyncEnumerable().ToListAsync();

    public async Task<ChatParticipantEntity?> GetByIdAsync(Guid id)
        => await _context.ChatParticipant.FindAsync(id);

    public async Task AddAsync(ChatParticipantEntity entity)
    {
        await _context.ChatParticipant.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(ChatParticipantEntity entity)
    {
        _context.ChatParticipant.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.ChatParticipant.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
