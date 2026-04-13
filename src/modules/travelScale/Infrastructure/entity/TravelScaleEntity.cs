using System;
using derTransporte.src.modules.cityOrMunicipality.Infrastructure.entity;
using derTransporte.src.modules.trips.Infrastructure.entity;

namespace derTransporte.src.modules.travelScale.Infrastructure.entity;

public class TravelScaleEntity
{
    public Guid Id { get; set; }
        public short Sequence { get; set; }              // SMALLINT
        public DateTime? ArrivalEstimated { get; set; }  // DATETIME - nullable
        public DateTime? ArrivalActual { get; set; }     // DATETIME - nullable
        public DateTime? DepartureActual { get; set; }   // DATETIME - nullable
        public Guid TripId { get; set; }                 // FK → trips
        public Guid CityId { get; set; }                 // FK → citiesormunicipalities
 
        public TripEntity? Trip { get; set; }
        public CityOrMunicipalityEntity? City { get; set; }

}
