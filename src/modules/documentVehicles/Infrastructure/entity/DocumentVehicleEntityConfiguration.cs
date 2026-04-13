using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.documentVehicles.Infrastructure.entity;

public class DocumentVehicleEntityConfiguration: IEntityTypeConfiguration<DocumentVehicleEntity>

{
    public void Configure(EntityTypeBuilder<DocumentVehicleEntity> builder)
    {
            builder.ToTable("documents_vehicles");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.DocumentNumber)
                   .HasColumnType("VARCHAR(100)");
 
            builder.Property(x => x.ExpirationDate)
                   .HasColumnType("DATE");
 
            builder.Property(x => x.FileUrl)
                   .HasColumnType("TEXT");
 
            builder.Property(x => x.ReviewedAt)
                   .HasColumnType("DATETIME");
 
            builder.HasOne(x => x.Vehicle)
                   .WithMany(x => x.Documents)
                   .HasForeignKey(x => x.VehicleId);
 
            /*builder.HasOne(x => x.TypeDocument)
                   .WithMany()
                   .HasForeignKey(x => x.TypeDocumentId);
 
            builder.HasOne(x => x.DocumentStatus)
                   .WithMany()
                   .HasForeignKey(x => x.DocumentStatusId);*/
        }

}
