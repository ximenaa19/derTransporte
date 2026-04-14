using System;

namespace derTransporte.src.modules.messageType.Infrastructure.entity;

public class MessageTypeEntity
{
    public Guid Id { get; set; }
        public string Name { get; set; }  = string.Empty;                // VARCHAR(100)
        public string Description { get; set; } = string.Empty;        // TEXT

}
