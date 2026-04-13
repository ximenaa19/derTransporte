using System;
using derTransporte.src.modules.drivers.Infrastructure.entity;

namespace derTransporte.src.modules.documentDrivers.Infrastructure.entity;

public class DocumentDriverEntity
{
    public Guid Id { get; set; }
        public string DocumentNumber { get; set; }  = string.Empty;     // VARCHAR(100)
        public DateTime ExpirationDate { get; set; }     // DATE
        public string FileUrl { get; set; }     = string.Empty;         // TEXT
        public Guid DriverId { get; set; }               // FK → drivers
        public Guid TypeDocumentId { get; set; }         // FK → type_documents
        public Guid DocumentStatusId { get; set; }       // FK → documents_status
 
        public DriverEntity? Driver { get; set; }
        //public TypeDocumentEntity TypeDocument { get; set; }
        //public DocumentsStatusEntity DocumentStatus { get; set; }

}
