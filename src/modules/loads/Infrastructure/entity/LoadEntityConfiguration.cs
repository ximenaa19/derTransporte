using System;
using derTransporte.src.modules.loadDetails.Infrastructure.entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.loads.Infrastructure.entity;

public class LoadEntityConfiguration : IEntityTypeConfiguration<LoadEntity>
{
    public void Configure(EntityTypeBuilder<LoadEntity> builder)
    {
            builder.ToTable("loads");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.OriginAddress).HasColumnType("TEXT");
            builder.Property(x => x.DestinationAddress).HasColumnType("TEXT");
            builder.Property(x => x.OriginCoords).HasColumnType("VARCHAR(50)");
            builder.Property(x => x.DestinationCoords).HasColumnType("VARCHAR(50)");
            builder.Property(x => x.WeightTons).HasColumnType("DECIMAL");
            builder.Property(x => x.VolumeM3).HasColumnType("DECIMAL");
            builder.Property(x => x.PickupDate).HasColumnType("TIMESTAMP");
            builder.Property(x => x.OfferedPrice).HasColumnType("DECIMAL");
            builder.Property(x => x.CreatedAt).HasColumnType("TIMESTAMP");
 
            // Relaciones N:1
            builder.HasOne(x => x.Customer)
                   .WithMany(x => x.Loads)
                   .HasForeignKey(x => x.CustomerId);
 
            builder.HasOne(x => x.TypeLoad)
                   .WithMany()
                   .HasForeignKey(x => x.TypeLoadId);
 
            // Dos FK a la misma tabla cities → hay que nombrar las columnas explícitamente
            builder.HasOne(x => x.OriginCity)
                   .WithMany()
                   .HasForeignKey(x => x.OriginCityId)
                   .HasConstraintName("FK_loads_origin_city");
 
            builder.HasOne(x => x.DestinationCity)
                   .WithMany()
                   .HasForeignKey(x => x.DestinationCityId)
                   .HasConstraintName("FK_loads_destination_city");
 
            // Relación 1:1 con load_details
            builder.HasOne(x => x.LoadDetails)
                   .WithOne(x => x.Load)
                   .HasForeignKey<LoadDetailsEntity>(x => x.LoadId);
        }

}
