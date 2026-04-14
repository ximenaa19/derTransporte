using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.driversVehicles.Infrastructure.entity;

public class DriverVehicleEntityConfiguration: IEntityTypeConfiguration<DriverVehicleEntity>
{
    public void Configure(EntityTypeBuilder<DriverVehicleEntity> builder)
    {
            builder.ToTable("drivers_vehicles");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.AssignedAt)
                   .IsRequired()
                   .HasColumnType("DATETIME");
 
            builder.Property(x => x.IsCurrent)
                   .HasColumnType("TINYINT(1)");
 
            // Dos relaciones N:1 independientes
            // (así se modela M:N con atributos en EF Core)
            builder.HasOne(x => x.Driver)
                   .WithMany(x => x.DriverVehicles)
                   .HasForeignKey(x => x.DriverId);
 
            builder.HasOne(x => x.Vehicle)
                   .WithMany(x => x.DriverVehicles)
                   .HasForeignKey(x => x.VehicleId);
        }


}
