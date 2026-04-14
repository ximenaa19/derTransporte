using System;
using derTransporte.src.modules.persons.Infrastructure.entity;

namespace derTransporte.src.modules.personRoles.Infrastructure.entity;

public class PersonRolesEntity
{
    public Guid Id { get; set; }
        public Guid PersonId { get; set; }               // FK → persons
        public Guid RoleId { get; set; }                 // FK → roles
 
        // Navigation properties
        public PersonEntity? Person { get; set; }
        //public RoleEntity Role { get; set; }

}
