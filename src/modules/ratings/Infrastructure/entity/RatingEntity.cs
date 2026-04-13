using System;
using derTransporte.src.modules.persons.Infrastructure.entity;
using derTransporte.src.modules.trips.Infrastructure.entity;

namespace derTransporte.src.modules.ratings.Infrastructure.entity;

public class RatingEntity
{
    public Guid Id { get; set; }
        public short Score { get; set; }                 // SMALLINT
        public string Comment { get; set; }   = string.Empty;           // TEXT
        public DateTime CreatedAt { get; set; }          // TIMESTAMP
        public Guid TripId { get; set; }                 // FK → trips
        public Guid EvaluatorId { get; set; }            // FK → persons (quien califica)
        public Guid EvaluatedId { get; set; }            // FK → persons (quien recibe la calificación)
 
        // Navigation properties
        public TripEntity? Trip { get; set; }
        public PersonEntity? Evaluator { get; set; }
        public PersonEntity? Evaluated { get; set; }

}
