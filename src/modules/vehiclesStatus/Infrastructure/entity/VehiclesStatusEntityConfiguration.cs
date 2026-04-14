using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.vehiclesStatus.Infrastructure.entity;

public class VehiclesStatusEntityConfiguration : IEntityTypeConfiguration<VehiclesStatusEntity>
{
    public void Configure(EntityTypeBuilder<VehiclesStatusEntity> builder)
    {
            builder.ToTable("vehicules_status");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasColumnType("VARCHAR(100)");
 
            builder.Property(x => x.Description)
                   .HasColumnType("TEXT");
        }

}
