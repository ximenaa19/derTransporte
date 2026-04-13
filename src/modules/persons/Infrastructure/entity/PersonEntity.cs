using System;
using derTransporte.src.modules.cityOrMunicipality.Infrastructure.entity;
using derTransporte.src.modules.drivers.Infrastructure.entity;

namespace derTransporte.src.modules.persons.Infrastructure.entity;

public class PersonEntity
{
    public Guid Id { get; set; }
        public string FirstName { get; set; }  = string.Empty;  // VARCHAR
        public string LastName { get; set; }  = string.Empty;  // VARCHAR
        public string Email { get; set; }  = string.Empty;  // VARCHAR
        public string Phone { get; set; }  = string.Empty;  // VARCHAR
        public int IdentificationNumber { get; set; }    // INTEGER
        public bool IsVerified { get; set; }             // BOOLEAN
        public DateTime CreatedAt { get; set; }          // DATE
        public Guid CityId { get; set; }                 // FK → citiesormunicipalities
        public Guid IdentificationTypeId { get; set; }   // FK → type_documents
        public Guid PersonStatusId { get; set; }         // FK → person_status
 
        // Navigation properties
        public CityOrMunicipalityEntity? City { get; set; }
       /* public TypeDocumentEntity IdentificationType { get; set; }
        public PersonStatusEntity PersonStatus { get; set; }*/
 
        // Hijos directos
        public DriverEntity? Driver { get; set; }
        /*public CustomerEntity Customer { get; set; }
        public AuthCredentialEntity AuthCredential { get; set; }*/

}
