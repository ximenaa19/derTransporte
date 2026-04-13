using System;
using derTransporte.src.modules.persons.Infrastructure.entity;

namespace derTransporte.src.modules.auditLog.Infrastructure.entity;

public class AuditLogEntity
{
    public Guid Id { get; set; }
        public string Action { get; set; }  = string.Empty;             // VARCHAR(50)
        public string TableName { get; set; }  = string.Empty;            // VARCHAR(100)
        public Guid RecordId { get; set; }               // CHAR(36)
        public string OldValues { get; set; }  = string.Empty;            // JSON  (reemplaza JSONB)
        public string NewValues { get; set; }  = string.Empty;            // JSON  (reemplaza JSONB)
        public string IpAddress { get; set; }  = string.Empty;            // VARCHAR(45)
        public string UserAgent { get; set; }  = string.Empty;            // TEXT
        public DateTime CreatedAt { get; set; }          // DATETIME
        public Guid UserId { get; set; }                 // FK → persons
 
        public PersonEntity? User { get; set; }

}
