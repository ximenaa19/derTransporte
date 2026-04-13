using System;
using derTransporte.src.modules.persons.Infrastructure.entity;

namespace derTransporte.src.modules.authCredentials.Infrastructure.entity;

public class AuthCredentialEntity
{
    public Guid Id { get; set; }
        public string Email { get; set; }    = string.Empty  ;       // VARCHAR
        public string PasswordHash { get; set; }  = string.Empty; // TEXT
        public DateTime? LastLogin { get; set; }     // TIMESTAMP - nullable
        public int FailedAttempts { get; set; }      // INTEGER
        public DateTime? LockUntil { get; set; }     // TIMESTAMP - nullable
        public bool IsActive { get; set; }           // BOOLEAN
        public Guid PersonId { get; set; }           // FK → persons
 
        // Navigation properties
        public PersonEntity? Person { get; set; }

}

