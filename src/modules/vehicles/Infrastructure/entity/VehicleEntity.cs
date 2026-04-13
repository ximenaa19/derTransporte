using System;
using derTransporte.src.modules.documentVehicles.Infrastructure.entity;
using derTransporte.src.modules.persons.Infrastructure.entity;

namespace derTransporte.src.modules.vehicles.Infrastructure.entity;

public class VehicleEntity
{
    public Guid Id { get; set; }
        public string Plate { get; set; } = string.Empty;               // VARCHAR - único
        public string Brand { get; set; } = string.Empty;               // VARCHAR
        public string Model { get; set; } = string.Empty;               // VARCHAR
        public int Year { get; set; }                    // INTEGER
        public string Color { get; set; } = string.Empty;                // VARCHAR
        public string ChassisNumber { get; set; } = string.Empty;        // VARCHAR
        public DateTime CreatedAt { get; set; }          // TIMESTAMP
        public Guid TypeVehicleId { get; set; }          // FK → type_vehicles
        public Guid OwnerId { get; set; }                // FK → persons
        public Guid StatusId { get; set; }               // FK → vehicules_status
 
        // Navigation properties
        //public TypeVehicleEntity TypeVehicle { get; set; }
        public PersonEntity? Owner { get; set; }
        //public VehiclesStatusEntity Status { get; set; }
 
        // Hijos
        //public ICollection<DriverVehicleEntity> DriverVehicles { get; set; }
        //public ICollection<CompanyVehicleEntity> CompanyVehicles { get; set; }
        public ICollection<DocumentVehicleEntity> Documents { get; set; } = new List<DocumentVehicleEntity>();

}
