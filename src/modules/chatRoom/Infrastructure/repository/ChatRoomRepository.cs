using System;
using System.Linq;
using derTransporte.src.modules.chatRoom.Infrastructure.entity;
using derTransporte.src.shared.context;
using Microsoft.EntityFrameworkCore;

namespace derTransporte.src.modules.chatRoom.Infrastructure.repository;

public class ChatRoomRepository
{
    private readonly AppDbContext _context;

    public ChatRoomRepository(AppDbContext context)
    {
        _context = context;
    }       

    public async Task<List<ChatRoomEntity>> GetAllAsync()
        => await _context.ChatRooms.ToListAsync();

    public async Task<ChatRoomEntity?> GetByIdAsync(Guid id)
        => await _context.ChatRooms.FindAsync(id);

    public async Task AddAsync(ChatRoomEntity entity)
    {
        await _context.ChatRooms.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(ChatRoomEntity entity)
    {
        _context.ChatRooms.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.ChatRooms.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }

}
