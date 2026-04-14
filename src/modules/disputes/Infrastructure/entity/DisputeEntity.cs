using System;
using derTransporte.src.modules.disputesStatus.Infrastructure.entity;
using derTransporte.src.modules.persons.Infrastructure.entity;
using derTransporte.src.modules.reasonDisputes.Infrastructure.entity;
using derTransporte.src.modules.trips.Infrastructure.entity;

namespace derTransporte.src.modules.disputes.Infrastructure.entity;

public class DisputeEntity
{
    public Guid Id { get; set; }
        public string Description { get; set; }  = string.Empty;           // TEXT
        public string EvidenceUrl { get; set; }  = string.Empty;           // TEXT
        public Guid TripId { get; set; }                 // FK → trips
        public Guid CreatedBy { get; set; }              // FK → persons
        public Guid ReasonCategoryId { get; set; }       // FK → reason_disputes
        public Guid StatusId { get; set; }               // FK → disputes_status
 
        // Navigation properties
        public TripEntity? Trip { get; set; }
        /// <summary>
        /// Gets or sets the person who created the dispute.
        /// </summary>
        public PersonEntity? Creator { get; set; }
        public ReasonDisputeEntity? ReasonCategory { get; set; }
        public DisputesStatusEntity? Status { get; set; }

}
