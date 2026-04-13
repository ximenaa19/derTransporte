using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.companyDocuments.Infrastructure.entity;

public class CompanyDocumentEntityConfiguration: IEntityTypeConfiguration<CompanyDocumentEntity>
{
    public void Configure(EntityTypeBuilder<CompanyDocumentEntity> builder)
    {
            builder.ToTable("company_documents");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.FileUrl)
                   .HasColumnType("TEXT");
 
            builder.Property(x => x.ExpirationDate)
                   .HasColumnType("DATE");
 
            builder.HasOne(x => x.Company)
                   .WithMany(x => x.Documents)
                   .HasForeignKey(x => x.CompanyId);
 
            /*builder.HasOne(x => x.TypeDocument)
                   .WithMany()
                   .HasForeignKey(x => x.TypeDocumentId);
 
            builder.HasOne(x => x.DocumentStatus)
                   .WithMany()
                   .HasForeignKey(x => x.DocumentStatusId);*/
        }

}
