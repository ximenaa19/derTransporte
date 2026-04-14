using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.typeVehicles.Infrastructure.entity;

public class TypeVehicleEntityConfiguration: IEntityTypeConfiguration<TypeVehicleEntity>
{
    public void Configure(EntityTypeBuilder<TypeVehicleEntity> builder)
    {
            builder.ToTable("type_vehicles");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasColumnType("VARCHAR(100)");
 
            builder.Property(x => x.CapacityKg)
                   .HasColumnType("DECIMAL(10,2)");
 
            builder.Property(x => x.CapacityM3)
                   .HasColumnType("DECIMAL(10,2)");
 
            builder.Property(x => x.Axles)
                   .HasColumnType("SMALLINT");
 
            builder.Property(x => x.Description)
                   .HasColumnType("TEXT");
        }

}
