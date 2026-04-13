using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.documentCustomers.Infrastructure.entity;

public class DocumentCustomerEntityConfiguration: IEntityTypeConfiguration<DocumentCustomerEntity>
{
    public void Configure(EntityTypeBuilder<DocumentCustomerEntity> builder)
    {
            builder.ToTable("documents_customers");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.DocumentNumber)
                   .HasColumnType("VARCHAR(100)");
 
            builder.Property(x => x.FileUrl)
                   .HasColumnType("TEXT");
 
            builder.HasOne(x => x.Customer)
                   .WithMany(x => x.Documents)
                   .HasForeignKey(x => x.CustomerId);
 
            /*builder.HasOne(x => x.TypeDocument)
                   .WithMany()
                   .HasForeignKey(x => x.TypeDocumentId);
 
            builder.HasOne(x => x.DocumentStatus)
                   .WithMany()
                   .HasForeignKey(x => x.DocumentStatusId);*/
        }

}
