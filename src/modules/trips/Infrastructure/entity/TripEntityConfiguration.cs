using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.trips.Infrastructure.entity;

public class TripEntityConfiguration : IEntityTypeConfiguration<TripEntity>
{
    public void Configure(EntityTypeBuilder<TripEntity> builder)
    {
            builder.ToTable("trips");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.FinalPrice).HasColumnType("DECIMAL");
            builder.Property(x => x.ManifestNumber).HasColumnType("VARCHAR(50)");
            builder.Property(x => x.TrackingToken).HasColumnType("VARCHAR(50)");
            builder.Property(x => x.StartTime).HasColumnType("TIMESTAMP");
            builder.Property(x => x.EndTime).HasColumnType("TIMESTAMP");
 
            // Relaciones N:1
            builder.HasOne(x => x.Load)
                   .WithMany()
                   .HasForeignKey(x => x.LoadId);
 
            builder.HasOne(x => x.Bid)
                   .WithOne(x => x.Trip)
                   .HasForeignKey<TripEntity>(x => x.BidId);
 
            builder.HasOne(x => x.Driver)
                   .WithMany()
                   .HasForeignKey(x => x.DriverId);
        }

}
