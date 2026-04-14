using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.disputes.Infrastructure.entity;

public class DisputeEntityConfiguration : IEntityTypeConfiguration<DisputeEntity>
{
    public void Configure(EntityTypeBuilder<DisputeEntity> builder)
    {
            builder.ToTable("disputes");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.Description).HasColumnType("TEXT");
            builder.Property(x => x.EvidenceUrl).HasColumnType("TEXT");
 
            builder.HasOne(x => x.Trip)
                   .WithMany(x => x.Disputes)
                   .HasForeignKey(x => x.TripId);
 
            builder.HasOne(x => x.Creator)
                   .WithMany()
                   .HasForeignKey(x => x.CreatedBy);
 
            builder.HasOne(x => x.ReasonCategory)
                   .WithMany()
                   .HasForeignKey(x => x.ReasonCategoryId);
 
            builder.HasOne(x => x.Status)
                   .WithMany()
                   .HasForeignKey(x => x.StatusId);
        }

}
