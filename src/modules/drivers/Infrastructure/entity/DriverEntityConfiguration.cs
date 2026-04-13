using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.drivers.Infrastructure.entity;

public class DriverEntityConfiguration : IEntityTypeConfiguration<DriverEntity>
{
    public void Configure(EntityTypeBuilder<DriverEntity> builder)
    {
            builder.ToTable("drivers");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.LicenseCategory).HasColumnType("VARCHAR(5)");
            builder.Property(x => x.ExperienceYears).HasColumnType("SMALLINT");
            builder.Property(x => x.IsAvailable).HasColumnType("tinyint(1)");
 
            // Relación 1:1 con persons (la FK vive en drivers)
            builder.HasOne(x => x.Person)
                   .WithOne(x => x.Driver)
                   .HasForeignKey<DriverEntity>(x => x.PersonId);
        }

}
