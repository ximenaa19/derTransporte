using System;
using derTransporte.src.modules.transportCompanies.Infrastructure.entity;

namespace derTransporte.src.modules.companyDocuments.Infrastructure.entity;

public class CompanyDocumentEntity
{
    public Guid Id { get; set; }
        public string FileUrl { get; set; } = string.Empty;              // TEXT
        public DateTime ExpirationDate { get; set; }     // DATE
        public Guid CompanyId { get; set; }              // FK → transport_companies
        public Guid TypeDocumentId { get; set; }         // FK → type_documents
        public Guid DocumentStatusId { get; set; }       // FK → documents_status
 
        public transportCompanyEntity? Company { get; set; }
        //public TypeDocumentEntity TypeDocument { get; set; }
        //public DocumentsStatusEntity DocumentStatus { get; set; }

}
