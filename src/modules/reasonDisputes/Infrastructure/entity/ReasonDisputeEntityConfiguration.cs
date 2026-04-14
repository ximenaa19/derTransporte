using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.reasonDisputes.Infrastructure.entity;

public class ReasonDisputeEntityConfiguration : IEntityTypeConfiguration<ReasonDisputeEntity>
{
    public void Configure(EntityTypeBuilder<ReasonDisputeEntity> builder)
    {
            builder.ToTable("reason_disputes");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasColumnType("VARCHAR(100)");
 
            builder.Property(x => x.Description)
                   .HasColumnType("TEXT");
        }

}
