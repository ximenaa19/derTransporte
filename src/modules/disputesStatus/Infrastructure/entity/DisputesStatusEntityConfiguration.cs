using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.disputesStatus.Infrastructure.entity;

public class DisputesStatusEntityConfiguration : IEntityTypeConfiguration<DisputesStatusEntity>
{
    public void Configure(EntityTypeBuilder<DisputesStatusEntity> builder)
    {
            builder.ToTable("disputes_status");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasColumnType("VARCHAR(100)");
 
            builder.Property(x => x.Description)
                   .HasColumnType("TEXT");
        }

}
