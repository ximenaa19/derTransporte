using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.loadImages.Infrastructure.entity;

public class LoadImageEntityConfiguration: IEntityTypeConfiguration<LoadImageEntity>
{
    public void Configure(EntityTypeBuilder<LoadImageEntity> builder)
    {
            builder.ToTable("load_images");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.ImageUrl)
                   .IsRequired()
                   .HasColumnType("TEXT");
 
            builder.Property(x => x.Description)
                   .HasColumnType("VARCHAR(100)");
 
            builder.HasOne(x => x.Load)
                   .WithMany(x => x.Images)
                   .HasForeignKey(x => x.LoadId);
        }

}
