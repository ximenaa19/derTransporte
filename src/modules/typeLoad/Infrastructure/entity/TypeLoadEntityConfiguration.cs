using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.typeLoad.Infrastructure.entity;

public class TypeLoadEntityConfiguration : IEntityTypeConfiguration<TypeLoadEntity>
{
    public void Configure(EntityTypeBuilder<TypeLoadEntity> builder)
    {
            builder.ToTable("type_load");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasColumnType("VARCHAR(100)");
 
            builder.Property(x => x.Description)
                   .HasColumnType("TEXT");
        }

}
