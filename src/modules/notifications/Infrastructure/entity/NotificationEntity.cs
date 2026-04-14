using System;
using derTransporte.src.modules.notificationType.Infrastructure.entity;
using derTransporte.src.modules.persons.Infrastructure.entity;

namespace derTransporte.src.modules.notifications.Infrastructure.entity;

public class NotificationEntity
{
    public Guid Id { get; set; }
        public string Title { get; set; }  = string.Empty;            // VARCHAR
        public string Body { get; set; }  = string.Empty;                // TEXT
        public string LinkUrl { get; set; }  = string.Empty;             // VARCHAR
        public bool IsRead { get; set; }  = false;                // BOOLEAN
        public DateTime CreatedAt { get; set; }         // TIMESTAMP
        public Guid PersonId { get; set; }              // FK → persons
        public Guid NotificationTypeId { get; set; }   // FK → notification_type
 
        // Navigation properties
        public PersonEntity? Person { get; set; }
        public NotificationTypeEntity? NotificationType { get; set; }

}
