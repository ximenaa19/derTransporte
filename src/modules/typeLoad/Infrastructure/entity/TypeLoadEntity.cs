using System;

namespace derTransporte.src.modules.typeLoad.Infrastructure.entity;

public class TypeLoadEntity
{
    public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;                // VARCHAR(100)
        public string Description { get; set; } = string.Empty;        // TEXT

}
