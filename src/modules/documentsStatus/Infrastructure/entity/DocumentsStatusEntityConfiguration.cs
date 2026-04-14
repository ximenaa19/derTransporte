using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.documentsStatus.Infrastructure.entity;

public class DocumentsStatusEntityConfiguration: IEntityTypeConfiguration<DocumentsStatusEntity>
{
    public void Configure(EntityTypeBuilder<DocumentsStatusEntity> builder)
    {
            builder.ToTable("documents_status");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasColumnType("VARCHAR(100)");
 
            builder.Property(x => x.Description)
                   .HasColumnType("TEXT");
        }

}
