using System;
using derTransporte.src.modules.drivers.Infrastructure.entity;
using derTransporte.src.modules.loads.Infrastructure.entity;
using derTransporte.src.modules.trips.Infrastructure.entity;
using derTransporte.src.modules.vehicles.Infrastructure.entity;

namespace derTransporte.src.modules.bids.Infrastructure.entity;

public class BidEntity
{
    public Guid Id { get; set; }
        public decimal Amount { get; set; }              // DECIMAL
        public TimeSpan EtaToPickup { get; set; }        // INTERVAL → TimeSpan en C#
        public DateTime CreatedAt { get; set; }          // TIMESTAMP
        public Guid LoadId { get; set; }                 // FK → loads
        public Guid DriverId { get; set; }               // FK → drivers
        public Guid VehicleId { get; set; }              // FK → vehicles
        public Guid StatusBidsId { get; set; }           // FK → status_bids
 
        // Navigation properties
        public LoadEntity? Load { get; set; }
        public DriverEntity? Driver { get; set; }
        public VehicleEntity? Vehicle { get; set; }
        //public StatusBidEntity StatusBid { get; set; }
 
        // Hijos
        public TripEntity? Trip { get; set; }

}
