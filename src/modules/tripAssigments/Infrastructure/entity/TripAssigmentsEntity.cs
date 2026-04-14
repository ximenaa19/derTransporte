using System;
using derTransporte.src.modules.persons.Infrastructure.entity;
using derTransporte.src.modules.trips.Infrastructure.entity;

namespace derTransporte.src.modules.tripAssigments.Infrastructure.entity;

public class TripAssigmentsEntity
{
    public Guid Id { get; set; }
        public bool IsActive { get; set; }               // TINYINT(1)
        public DateTime AssignedAt { get; set; }         // DATETIME
        public Guid TripId { get; set; }                 // FK → trips
        public Guid PersonId { get; set; }               // FK → persons
        public Guid AssignmentRoleId { get; set; }       // FK → assignment_role (ej: conductor, asistente)
 
        // Navigation properties
        public TripEntity? Trip { get; set; }
        public PersonEntity? Person { get; set; }
        //public AssignmentsRoleEntity AssignmentRole { get; set; }

}
