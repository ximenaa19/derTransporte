using System;
using derTransporte.src.modules.customers.Infrastructure.entity;

namespace derTransporte.src.modules.documentCustomers.Infrastructure.entity;

public class DocumentCustomerEntity
{
    public Guid Id { get; set; }
        public string DocumentNumber { get; set; } = string.Empty;       // VARCHAR(100)
        public string FileUrl { get; set; } = string.Empty;              // TEXT
        public Guid CustomerId { get; set; }             // FK → customers
        public Guid TypeDocumentId { get; set; }         // FK → type_documents
        public Guid DocumentStatusId { get; set; }       // FK → documents_status
 
        public CustomerEntity? Customer { get; set; }
        //public TypeDocumentEntity TypeDocument { get; set; }
        //public DocumentsStatusEntity DocumentStatus { get; set; }

}
