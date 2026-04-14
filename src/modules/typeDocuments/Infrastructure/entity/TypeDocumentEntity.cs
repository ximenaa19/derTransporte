using System;
using derTransporte.src.modules.documentCategory.Infrastructure.entity;

namespace derTransporte.src.modules.typeDocuments.Infrastructure.entity;

public class TypeDocumentEntity
{
    public Guid Id { get; set; }
        public string Name { get; set; }   = string.Empty;              // VARCHAR(100)
        public Guid CategoryId { get; set; }             // FK → document_category
 
        // Navigation property
        public DocumentCategoryEntity? Category { get; set; }

}
