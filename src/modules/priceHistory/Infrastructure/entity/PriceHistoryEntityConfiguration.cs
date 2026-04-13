using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.priceHistory.Infrastructure.entity;

public class PriceHistoryEntityConfiguration: IEntityTypeConfiguration<PriceHistoryEntity>
{
    public void Configure(EntityTypeBuilder<PriceHistoryEntity> builder)
    {
            builder.ToTable("price_history");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.MinPrice).HasColumnType("DECIMAL(10,2)");
            builder.Property(x => x.MaxPrice).HasColumnType("DECIMAL(10,2)");
            builder.Property(x => x.AveragePrice).HasColumnType("DECIMAL(10,2)");
            builder.Property(x => x.SicetacReferencePrice).HasColumnType("DECIMAL(10,2)");
            builder.Property(x => x.ReferenceDate).HasColumnType("DATE");
 
            // Dos FK a la misma tabla cities → nombrar constraints
            builder.HasOne(x => x.OriginCity)
                   .WithMany()
                   .HasForeignKey(x => x.OriginCityId)
                   .HasConstraintName("FK_price_history_origin_city");
 
            builder.HasOne(x => x.DestinationCity)
                   .WithMany()
                   .HasForeignKey(x => x.DestinationCityId)
                   .HasConstraintName("FK_price_history_destination_city");
 
            /*builder.HasOne(x => x.TypeVehicle)
                   .WithMany()
                   .HasForeignKey(x => x.TypeVehicleId);
 
            builder.HasOne(x => x.TypeLoad)
                   .WithMany()
                   .HasForeignKey(x => x.TypeLoadId);*/
        }

}
