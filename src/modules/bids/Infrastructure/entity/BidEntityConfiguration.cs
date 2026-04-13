using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.bids.Infrastructure.entity;

public class BidEntityConfiguration : IEntityTypeConfiguration<BidEntity>
{
    public void Configure(EntityTypeBuilder<BidEntity> builder)
    {
            builder.ToTable("bids");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.Amount).HasColumnType("DECIMAL");
            builder.Property(x => x.CreatedAt).HasColumnType("TIMESTAMP");
 
            // Relaciones N:1
            builder.Property(x => x.EtaToPickup).HasColumnType("TIME");
 
            // Relaciones N:1
            builder.HasOne(x => x.Load)
                   .WithMany(x => x.Bids)
                   .HasForeignKey(x => x.LoadId);
 
            builder.HasOne(x => x.Driver)
                   .WithMany(x => x.Bids)
                   .HasForeignKey(x => x.DriverId);
 
            builder.HasOne(x => x.Vehicle)
                   .WithMany()
                   .HasForeignKey(x => x.VehicleId);
 
            /*builder.HasOne(x => x.StatusBid)
                   .WithMany()
                   .HasForeignKey(x => x.StatusBidsId);*/
        }

}
