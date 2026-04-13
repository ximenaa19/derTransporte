
using System;
using derTransporte.src.modules.cityOrMunicipality.Infrastructure.entity;
using derTransporte.src.modules.companyDocuments.Infrastructure.entity;
using derTransporte.src.modules.persons.Infrastructure.entity;

namespace derTransporte.src.modules.transportCompanies.Infrastructure.entity;

public class transportCompanyEntity
{
     public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty ;             // VARCHAR
        public string Nit { get; set; }  = string.Empty  ;            // VARCHAR - único
        public string EmailCorp { get; set; } = string.Empty ;          // VARCHAR - único
        public string ContactName { get; set; } = string.Empty ;        // VARCHAR
        public string ContactEmail { get; set; } = string.Empty ;       // VARCHAR - único
        public string ContactPhone { get; set; } = string.Empty   ;     // VARCHAR
        public string Address { get; set; } = string.Empty     ;         // TEXT
        public string LogoUrl { get; set; }  = string.Empty;            // TEXT
        public DateTime? VerifiedAt { get; set; }        // TIMESTAMP - nullable
        public Guid CityId { get; set; }                 // FK → citiesormunicipalities
        public Guid StatusId { get; set; }               // FK → companies_status
        public Guid LegalRepresentativeId { get; set; }  // FK → persons
 
        // Navigation properties
        public CityOrMunicipalityEntity? City { get; set; }
        //public CompaniesStatusEntity Status { get; set; }
        public PersonEntity? LegalRepresentative { get; set; }
 
        // Hijos
      //  public ICollection<CompanyVehicleEntity> CompanyVehicles { get; set; }
        public ICollection<CompanyDocumentEntity> Documents { get; set; } = new List<CompanyDocumentEntity>();
        //public ICollection<PersonTransportEntity> PersonTransports { get; set; }


}
