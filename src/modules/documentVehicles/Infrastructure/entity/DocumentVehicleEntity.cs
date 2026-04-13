using System;
using derTransporte.src.modules.vehicles.Infrastructure.entity;

namespace derTransporte.src.modules.documentVehicles.Infrastructure.entity;

public class DocumentVehicleEntity
{
    public Guid Id { get; set; }
        public string DocumentNumber { get; set; } = string.Empty;       // VARCHAR(100)
        public DateTime ExpirationDate { get; set; }     // DATE
        public string FileUrl { get; set; } = string.Empty;              // TEXT
        public DateTime? ReviewedAt { get; set; }        // DATETIME - nullable
        public Guid VehicleId { get; set; }              // FK → vehicles
        public Guid TypeDocumentId { get; set; }         // FK → type_documents
        public Guid DocumentStatusId { get; set; }       // FK → documents_status
 
        public VehicleEntity? Vehicle { get; set; }
        //public TypeDocumentEntity TypeDocument { get; set; }
        //public DocumentsStatusEntity DocumentStatus { get; set; }

}
