using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.stateOrRegions.Infrastructure.entity;

public class StateOrRegionsEntityConfiguration
{
    public void Configure(EntityTypeBuilder<StateOrRegionsEntity> builder)
    {
        builder.ToTable("stateOrRegions");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name).HasMaxLength(60);
            builder.Property(e => e.Code).HasMaxLength(10);
            builder.Property(e => e.CountryId).HasColumnName("countryId");

            builder.HasOne(e => e.Country).WithMany().HasForeignKey(e => e.CountryId).OnDelete(DeleteBehavior.Cascade);

    }

}

