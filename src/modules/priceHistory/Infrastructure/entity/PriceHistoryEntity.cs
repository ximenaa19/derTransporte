using System;
using derTransporte.src.modules.cityOrMunicipality.Infrastructure.entity;

namespace derTransporte.src.modules.priceHistory.Infrastructure.entity;

public class PriceHistoryEntity
{
    public Guid Id { get; set; }
        public decimal MinPrice { get; set; }                // DECIMAL(10,2)
        public decimal MaxPrice { get; set; }                // DECIMAL(10,2)
        public decimal AveragePrice { get; set; }            // DECIMAL(10,2)
        public decimal SicetacReferencePrice { get; set; }   // DECIMAL(10,2)
        public DateTime ReferenceDate { get; set; }          // DATE
        public Guid OriginCityId { get; set; }               // FK → citiesormunicipalities
        public Guid DestinationCityId { get; set; }          // FK → citiesormunicipalities
        public Guid TypeVehicleId { get; set; }              // FK → type_vehicles
        public Guid TypeLoadId { get; set; }                 // FK → type_load
 
        public CityOrMunicipalityEntity? OriginCity { get; set; }
        public CityOrMunicipalityEntity? DestinationCity { get; set; }
        //public TypeVehicleEntity? TypeVehicle { get; set; }
        //public TypeLoadEntity? TypeLoad { get; set; }

}
