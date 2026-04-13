using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.travelScale.Infrastructure.entity;

public class TravelScaleEntityConfiguration: IEntityTypeConfiguration<TravelScaleEntity>
{
    public void Configure(EntityTypeBuilder<TravelScaleEntity> builder)
    {
            builder.ToTable("travel_scale");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.Sequence).HasColumnType("SMALLINT");
            builder.Property(x => x.ArrivalEstimated).HasColumnType("DATETIME");
            builder.Property(x => x.ArrivalActual).HasColumnType("DATETIME");
            builder.Property(x => x.DepartureActual).HasColumnType("DATETIME");
 
            builder.HasOne(x => x.Trip)
                   .WithMany(x => x.TravelScales)
                   .HasForeignKey(x => x.TripId);
 
            builder.HasOne(x => x.City)
                   .WithMany()
                   .HasForeignKey(x => x.CityId);
        }
    

}
