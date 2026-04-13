using System;
using derTransporte.src.modules.persons.Infrastructure.entity;

namespace derTransporte.src.modules.authSessions.Infrastructure.entity;

public class AuthSessionEntity
{
    public Guid Id { get; set; }
        public string RefreshToken { get; set; }   = string.Empty;           // VARCHAR(255)
        public string AccessToken { get; set; }    = string.Empty;           // VARCHAR(255)    
        public DateTime ExpiresAt { get; set; }          // DATETIME
        public string IpAddress { get; set; }  = string.Empty;           // VARCHAR(255)    
        public string DeviceInfo { get; set; }  = string.Empty;         // TEXT    
        public DateTime CreatedAt { get; set; }          // DATETIME
        public Guid PersonId { get; set; }               // FK → persons
 
        public PersonEntity? Person { get; set; }

}
