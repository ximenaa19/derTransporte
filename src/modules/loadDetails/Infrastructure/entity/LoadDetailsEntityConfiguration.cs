using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.loadDetails.Infrastructure.entity;

public class LoadDetailsEntityConfiguration : IEntityTypeConfiguration<LoadDetailsEntity>
{
    public void Configure(EntityTypeBuilder<LoadDetailsEntity> builder)
    {
            builder.ToTable("load_details");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.RequiresPackaging).HasColumnType("TINYINT(1)");
            builder.Property(x => x.IsFragile).HasColumnType("TINYINT(1)");
            builder.Property(x => x.IsStackable).HasColumnType("TINYINT(1)");
            builder.Property(x => x.RequiredInsurance).HasColumnType("TINYINT(1)");
            builder.Property(x => x.SpecialInstructions).HasColumnType("TEXT");
 
            // JSON reemplaza JSONB en MySQL
            builder.Property(x => x.Metadata).HasColumnType("JSON");
 
            // 1:1 → un load_details pertenece a exactamente un load
            builder.HasOne(x => x.Load)
                   .WithOne(x => x.LoadDetails)
                   .HasForeignKey<LoadDetailsEntity>(x => x.LoadId);
        }

}
