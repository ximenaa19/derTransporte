using System;
using derTransporte.src.modules.chatRoom.Infrastructure.entity;
using derTransporte.src.modules.messageType.Infrastructure.entity;
using derTransporte.src.modules.persons.Infrastructure.entity;

namespace derTransporte.src.modules.chatMessages.Infrastructure.entity;

public class ChatMessageEntity
{
    public Guid Id { get; set; }
        public string MessageContent { get; set; }    = string.Empty;           // TEXT
        public bool IsRead { get; set; }                 // TINYINT(1)
        public DateTime CreatedAt { get; set; }          // DATETIME
        public Guid ChatRoomId { get; set; }             // FK → chat_rooms
        public Guid SenderId { get; set; }               // FK → persons
        public Guid MessageTypeId { get; set; }          // FK → message_type
 
        public ChatRoomEntity? ChatRoom { get; set; }
        public PersonEntity? Sender { get; set; }
        public MessageTypeEntity? MessageType { get; set; }

}
