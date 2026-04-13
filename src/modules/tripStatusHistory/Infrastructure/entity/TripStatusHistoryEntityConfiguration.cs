using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.tripStatusHistory.Infrastructure.entity;

public class TripStatusHistoryEntityConfiguration: IEntityTypeConfiguration<TripStatusHistoryEntity>
{
    public void Configure(EntityTypeBuilder<TripStatusHistoryEntity> builder)
    {
            builder.ToTable("trip_status_history");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.StatusName)
                   .IsRequired()
                   .HasColumnType("VARCHAR(100)");
 
            
            builder.Property(x => x.LocationCoords)
                   .HasColumnType("VARCHAR(100)");
 
            builder.Property(x => x.Notes).HasColumnType("TEXT");
            builder.Property(x => x.CreatedAt).HasColumnType("DATETIME");
 
            builder.HasOne(x => x.Trip)
                   .WithMany(x => x.StatusHistory)
                   .HasForeignKey(x => x.TripId);
        }

}
