using System;

namespace derTransporte.src.modules.reasonDisputes.Infrastructure.entity;

public class ReasonDisputeEntity
{
    public Guid Id { get; set; }
        public string Name { get; set; }    = string.Empty;             // VARCHAR(100)
        public string Description { get; set; } = string.Empty;        // TEXT

}
