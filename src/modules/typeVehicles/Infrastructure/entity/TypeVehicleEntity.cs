using System;

namespace derTransporte.src.modules.typeVehicles.Infrastructure.entity;

public class TypeVehicleEntity
{
    public Guid Id { get; set; }
        public string Name { get; set; }    = string.Empty;             // VARCHAR(100)
        public decimal CapacityKg { get; set; }          // DECIMAL(10,2) - capacidad en kilogramos
        public decimal CapacityM3 { get; set; }          // DECIMAL(10,2) - capacidad en metros cúbicos
        public short Axles { get; set; }                 // SMALLINT - número de ejes
        public string Description { get; set; } = string.Empty;        // TEXT

}
