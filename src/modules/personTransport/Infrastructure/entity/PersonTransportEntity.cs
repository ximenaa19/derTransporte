using System;
using derTransporte.src.modules.persons.Infrastructure.entity;
using derTransporte.src.modules.transportCompanies.Infrastructure.entity;

namespace derTransporte.src.modules.personTransport.Infrastructure.entity;

public class PersonTransportEntity
{
    public Guid Id { get; set; }
        public bool IsActive { get; set; }               // TINYINT(1)
        public DateTime JoinedAt { get; set; }           // DATETIME - fecha en que se vinculó
        public Guid PersonId { get; set; }               // FK → persons
        public Guid CompanyId { get; set; }              // FK → transport_companies
        public Guid RelationTypeId { get; set; }         // FK → relation_type (ej: empleado, propietario, socio)
 
        // Navigation properties
        public PersonEntity? Person { get; set; }
        public transportCompanyEntity? Company { get; set; }
        //public RelationTypeEntity RelationType { get; set; }

}
