using System;
using derTransporte.src.modules.loads.Infrastructure.entity;
using derTransporte.src.modules.persons.Infrastructure.entity;

namespace derTransporte.src.modules.loadStatusHistory.Infrastructure.entity;

public class LoadStatusHistoryEntity
{
    public Guid Id { get; set; }
        public string StatusName { get; set; }  = string.Empty;            // VARCHAR
        public string Notes { get; set; }  = string.Empty;                // TEXT
        public DateTime CreatedAt { get; set; }          // DATETIME
        public Guid LoadId { get; set; }                 // FK → loads
        public Guid ChangedById { get; set; }            // FK → persons
 
        public LoadEntity? Load { get; set; }
        public PersonEntity? ChangedBy { get; set; }

}
