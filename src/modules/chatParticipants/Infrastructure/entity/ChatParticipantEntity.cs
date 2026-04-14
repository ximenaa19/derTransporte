using System;
using derTransporte.src.modules.chatRoom.Infrastructure.entity;
using derTransporte.src.modules.persons.Infrastructure.entity;

namespace derTransporte.src.modules.chatParticipants.Infrastructure.entity;

public class ChatParticipantEntity
{
    public Guid Id { get; set; }
        public DateTime JoinedAt { get; set; }           // DATETIME - cuándo entró a la sala
        public Guid ChatRoomId { get; set; }             // FK → chat_rooms
        public Guid PersonId { get; set; }               // FK → persons
 
        // Navigation properties
        public ChatRoomEntity? ChatRoom { get; set; }
        public PersonEntity? Person { get; set; }

}
