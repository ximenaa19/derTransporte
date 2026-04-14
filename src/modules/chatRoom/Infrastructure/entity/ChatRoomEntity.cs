using System;
using derTransporte.src.modules.chatMessages.Infrastructure.entity;
using derTransporte.src.modules.chatParticipants.Infrastructure.entity;
using derTransporte.src.modules.loads.Infrastructure.entity;
using derTransporte.src.modules.trips.Infrastructure.entity;

namespace derTransporte.src.modules.chatRoom.Infrastructure.entity;

public class ChatRoomEntity
{
    public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }          // TIMESTAMP
        public Guid LoadId { get; set; }                 // FK → loads
        public Guid TripId { get; set; }                 // FK → trips
        public Guid StatusId { get; set; }               // FK → status_chat
 
        // Navigation properties
        public LoadEntity? Load { get; set; }
        public TripEntity? Trip { get; set; }
        //public StatusChatEntity? Status { get; set; }
 
        // Hijos
        public ICollection<ChatParticipantEntity> Participants { get; set; } = new List<ChatParticipantEntity>();
        public ICollection<ChatMessageEntity> Messages { get; set; } = new List<ChatMessageEntity>();

}
