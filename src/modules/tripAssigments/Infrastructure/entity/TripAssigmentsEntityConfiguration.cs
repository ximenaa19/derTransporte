using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.tripAssigments.Infrastructure.entity;

public class TripAssigmentsEntityConfiguration: IEntityTypeConfiguration<TripAssigmentsEntity>
{
    public void Configure(EntityTypeBuilder<TripAssigmentsEntity> builder)
    {
            builder.ToTable("trip_assignments");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.IsActive)
                   .HasColumnType("TINYINT(1)");
 
            builder.Property(x => x.AssignedAt)
                   .IsRequired()
                   .HasColumnType("DATETIME");
 
            builder.HasOne(x => x.Trip)
                   .WithMany(x => x.Assignments)
                   .HasForeignKey(x => x.TripId);
 
            builder.HasOne(x => x.Person)
                   .WithMany()
                   .HasForeignKey(x => x.PersonId);
 
            // N:1 → rol de la asignación (catálogo)
            /*builder.HasOne(x => x.AssignmentRole)
                   .WithMany()
                   .HasForeignKey(x => x.AssignmentRoleId);*/
        }

}
