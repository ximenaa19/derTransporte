using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.vehicles.Infrastructure.entity;

public class VehicleEntityConfiguration : IEntityTypeConfiguration<VehicleEntity>
{
    public void Configure(EntityTypeBuilder<VehicleEntity> builder)
    {
            builder.ToTable("vehicles");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.Plate).IsRequired().HasColumnType("VARCHAR(10)");
            builder.Property(x => x.Brand).HasColumnType("VARCHAR(50)");
            builder.Property(x => x.Model).HasColumnType("VARCHAR(50)");
            builder.Property(x => x.Year).HasColumnType("INTEGER");
            builder.Property(x => x.Color).HasColumnType("VARCHAR(30)");
            builder.Property(x => x.ChassisNumber).HasColumnType("VARCHAR(50)");
            builder.Property(x => x.CreatedAt).HasColumnType("TIMESTAMP");
 
            // Índice único en placa
            builder.HasIndex(x => x.Plate).IsUnique();
 
            // Relaciones N:1
            /*builder.HasOne(x => x.TypeVehicle)
                   .WithMany()
                   .HasForeignKey(x => x.TypeVehicleId);*/
 
            builder.HasOne(x => x.Owner)
                   .WithMany()
                   .HasForeignKey(x => x.OwnerId);
 
            /*builder.HasOne(x => x.Status)
                   .WithMany()
                   .HasForeignKey(x => x.StatusId);*/
        }
}
