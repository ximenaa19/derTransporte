using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.documentDrivers.Infrastructure.entity;

public class DocumentDriverEntityConfiguration: IEntityTypeConfiguration<DocumentDriverEntity>
{
    public void Configure(EntityTypeBuilder<DocumentDriverEntity> builder)
    {
            builder.ToTable("documents_drivers");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.DocumentNumber)
                   .HasColumnType("VARCHAR(100)");
 
            builder.Property(x => x.ExpirationDate)
                   .HasColumnType("DATE");
 
            builder.Property(x => x.FileUrl)
                   .HasColumnType("TEXT");
 
            builder.HasOne(x => x.Driver)
                   .WithMany(x => x.Documents)
                   .HasForeignKey(x => x.DriverId);
 
           /* builder.HasOne(x => x.TypeDocument)
                   .WithMany()
                   .HasForeignKey(x => x.TypeDocumentId);
 
            builder.HasOne(x => x.DocumentStatus)
                   .WithMany()
                   .HasForeignKey(x => x.DocumentStatusId);*/
        }
    

}
