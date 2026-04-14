using System;
using derTransporte.src.modules.typeDocuments.Infrastructure.entity;

namespace derTransporte.src.modules.documentCategory.Infrastructure.entity;

public class DocumentCategoryEntity
{
    public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;                // VARCHAR(100)
        public string Description { get; set; } = string.Empty;          // TEXT
 
        // Navigation property
        public ICollection<TypeDocumentEntity> TypeDocuments { get; set; } = new List<TypeDocumentEntity>();

}
