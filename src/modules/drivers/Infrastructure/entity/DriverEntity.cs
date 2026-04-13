using System;
using derTransporte.src.modules.bids.Infrastructure.entity;
using derTransporte.src.modules.persons.Infrastructure.entity;

namespace derTransporte.src.modules.drivers.Infrastructure.entity;

public class DriverEntity
{
     public Guid Id { get; set; }
        public string LicenseCategory { get; set; } = string.Empty;  // VARCHAR
        public short ExperienceYears { get; set; }       // SMALLINT
        public bool IsAvailable { get; set; }            // BOOLEAN
        public Guid PersonId { get; set; }               // FK → persons
 
        // Navigation properties
        public PersonEntity? Person { get; set; }
 
        // Hijos
       //public ICollection<DriverVehicleEntity> DriverVehicles { get; set; }
        //public ICollection<DocumentDriverEntity> Documents { get; set; }
        public ICollection<BidEntity> Bids { get; set; }= new List<BidEntity>();
}
