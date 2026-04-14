using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.typeDocuments.Infrastructure.entity;

public class TypeDocumentEntityConfiguration: IEntityTypeConfiguration<TypeDocumentEntity>
{
    public void Configure(EntityTypeBuilder<TypeDocumentEntity> builder)
    {
            builder.ToTable("type_documents");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasColumnType("VARCHAR(100)");
 
            // N:1 → un tipo de documento pertenece a una categoría
            builder.HasOne(x => x.Category)
                   .WithMany(x => x.TypeDocuments)
                   .HasForeignKey(x => x.CategoryId);
        }

}
