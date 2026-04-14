using System;
using derTransporte.src.modules.drivers.Infrastructure.entity;
using derTransporte.src.modules.vehicles.Infrastructure.entity;

namespace derTransporte.src.modules.driversVehicles.Infrastructure.entity;

public class DriverVehicleEntity
{
    public Guid Id { get; set; }
        public DateTime AssignedAt { get; set; }         // DATETIME - cuándo se asignó
        public bool IsCurrent { get; set; }              // TINYINT(1) - si es la asignación activa
        public Guid DriverId { get; set; }               // FK → drivers
        public Guid VehicleId { get; set; }              // FK → vehicles
 
        // Navigation properties
        public DriverEntity? Driver { get; set; }
        public VehicleEntity? Vehicle { get; set; }

}
