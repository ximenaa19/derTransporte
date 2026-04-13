using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.loadStatusHistory.Infrastructure.entity;

public class LoadStatusHistoryEntityConfiguration: IEntityTypeConfiguration<LoadStatusHistoryEntity>
{
    public void Configure(EntityTypeBuilder<LoadStatusHistoryEntity> builder)
    {
            builder.ToTable("load_status_history");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.StatusName)
                   .IsRequired()
                   .HasColumnType("VARCHAR(100)");
 
            builder.Property(x => x.Notes)
                   .HasColumnType("TEXT");
 
            builder.Property(x => x.CreatedAt)
                   .HasColumnType("DATETIME");
 
            builder.HasOne(x => x.Load)
                   .WithMany(x => x.StatusHistory)
                   .HasForeignKey(x => x.LoadId);
 
            builder.HasOne(x => x.ChangedBy)
                   .WithMany()
                   .HasForeignKey(x => x.ChangedById);
        }

}
