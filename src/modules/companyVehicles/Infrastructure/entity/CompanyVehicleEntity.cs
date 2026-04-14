using System;
using derTransporte.src.modules.transportCompanies.Infrastructure.entity;
using derTransporte.src.modules.vehicles.Infrastructure.entity;

namespace derTransporte.src.modules.companyVehicles.Infrastructure.entity;

public class CompanyVehicleEntity
{
    public Guid Id { get; set; }
        public bool IsActive { get; set; }               // TINYINT(1) - si el vehículo está activo en la empresa
        public Guid CompanyId { get; set; }              // FK → transport_companies
        public Guid VehicleId { get; set; }              // FK → vehicles
 
        // Navigation properties
        public transportCompanyEntity? Company { get; set; }
        public VehicleEntity? Vehicle { get; set; }

}
