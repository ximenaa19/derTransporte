using System;
using derTransporte.src.modules.trips.Infrastructure.entity;

namespace derTransporte.src.modules.tripStatusHistory.Infrastructure.entity;

public class TripStatusHistoryEntity
{
    public Guid Id { get; set; }
        public string StatusName { get; set; } = string.Empty;           // VARCHAR(100)
        public string LocationCoords { get; set; } = string.Empty;       // VARCHAR(100) - reemplaza GEOGRAPHY
        public string Notes { get; set; } = string.Empty;                // TEXT
        public DateTime CreatedAt { get; set; }          // DATETIME
        public Guid TripId { get; set; }                 // FK → trips
 
        public TripEntity? Trip { get; set; }
}
