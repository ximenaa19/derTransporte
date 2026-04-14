using System;

namespace derTransporte.src.modules.documentsStatus.Infrastructure.entity;

public class DocumentsStatusEntity
{
    public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;                // VARCHAR(100)
        public string Description { get; set; } = string.Empty;        // TEXT

}
