using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.statusBids.Infarstructure.entity;

public class StatusBidEntityConfiguration : IEntityTypeConfiguration<StatusBidEntity>
{
    public void Configure(EntityTypeBuilder<StatusBidEntity> builder)
    {
            builder.ToTable("status_bids");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasColumnType("VARCHAR(100)");
 
            builder.Property(x => x.Description)
                   .HasColumnType("TEXT");
        }

}
