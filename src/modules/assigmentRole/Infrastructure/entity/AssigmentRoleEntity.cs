using System;

namespace derTransporte.src.modules.assigmentRole.Infrastructure.entity;

public class AssigmentRoleEntity
{
    public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;                // VARCHAR(100)
        public string Description { get; set; } = string.Empty;        // TEXT

}
