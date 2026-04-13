using System;
using derTransporte.src.modules.bids.Infrastructure.entity;
using derTransporte.src.modules.disputes.Infrastructure.entity;
using derTransporte.src.modules.drivers.Infrastructure.entity;
using derTransporte.src.modules.loads.Infrastructure.entity;
using derTransporte.src.modules.ratings.Infrastructure.entity;
using derTransporte.src.modules.travelScale.Infrastructure.entity;
using derTransporte.src.modules.tripStatusHistory.Infrastructure.entity;

namespace derTransporte.src.modules.trips.Infrastructure.entity;

public class TripEntity
{
    public Guid Id { get; set; }
        public decimal FinalPrice { get; set; }          // DECIMAL
        public string ManifestNumber { get; set; } = string.Empty;      // VARCHAR
        public string TrackingToken { get; set; } = string.Empty;        // VARCHAR
        public DateTime? StartTime { get; set; }         // TIMESTAMP - nullable
        public DateTime? EndTime { get; set; }           // TIMESTAMP - nullable
        public Guid LoadId { get; set; }                 // FK → loads
        public Guid BidId { get; set; }                  // FK → bids
        public Guid DriverId { get; set; }               // FK → drivers
 
        // Navigation properties
        public LoadEntity? Load { get; set; }
        public BidEntity? Bid { get; set; }
        public DriverEntity? Driver { get; set; }
 
        // Hijos
        public ICollection<TravelScaleEntity> TravelScales { get; set; }= new List<TravelScaleEntity>();
        public ICollection<TripStatusHistoryEntity> StatusHistory { get; set; }= new List<TripStatusHistoryEntity>();
        //public ICollection<TripAssignmentEntity> Assignments { get; set; }*/
        public ICollection<RatingEntity> Ratings { get; set; }= new List<RatingEntity>();
        public ICollection<DisputeEntity> Disputes { get; set; }=  new List<DisputeEntity>();
}
