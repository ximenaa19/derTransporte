using System;
using derTransporte.src.modules.bids.Infrastructure.entity;
using derTransporte.src.modules.cityOrMunicipality.Infrastructure.entity;
using derTransporte.src.modules.customers.Infrastructure.entity;

namespace derTransporte.src.modules.loads.Infrastructure.entity;

public class LoadEntity
{
    public Guid Id { get; set; }
        public string OriginAddress { get; set; } = string.Empty;       // TEXT
        public string DestinationAddress { get; set; }  = string.Empty; // TEXT
        public string OriginCoords { get; set; }  = string.Empty;        // GEOGRAPHY
        public string DestinationCoords { get; set; }    = string.Empty;  // GEOGRAPHY
        public decimal WeightTons { get; set; }          // DECIMAL
        public decimal VolumeM3 { get; set; }            // DECIMAL
        public DateTime PickupDate { get; set; }         // TIMESTAMP
        public decimal OfferedPrice { get; set; }        // DECIMAL
        public DateTime CreatedAt { get; set; }          // TIMESTAMP
        public Guid CustomerId { get; set; }             // FK → customers
        public Guid TypeLoadId { get; set; }             // FK → type_load
        public Guid OriginCityId { get; set; }           // FK → citiesormunicipalities
        public Guid DestinationCityId { get; set; }      // FK → citiesormunicipalities
        public Guid StatusId { get; set; }               // FK → (catálogo de status)
 
        // Navigation properties
        public CustomerEntity? Customer { get; set; }
        //public TypeLoadEntity TypeLoad { get; set; }
        public CityOrMunicipalityEntity? OriginCity { get; set; }
        public CityOrMunicipalityEntity? DestinationCity { get; set; }
 
        // Hijos
        //public LoadDetailsEntity LoadDetails { get; set; }
        //public ICollection<LoadImageEntity> Images { get; set; }
        //public ICollection<LoadStatusHistoryEntity> StatusHistory { get; set; }
        public ICollection<BidEntity> Bids { get; set; }= new List<BidEntity>();

}
