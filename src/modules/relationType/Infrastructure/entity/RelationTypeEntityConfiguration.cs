using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.relationType.Infrastructure.entity;

public class RelationTypeEntityConfiguration: IEntityTypeConfiguration<RelationTypeEntity>
{
    public void Configure(EntityTypeBuilder<RelationTypeEntity> builder)
    {
            builder.ToTable("relation_type");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasColumnType("VARCHAR(100)");
 
            builder.Property(x => x.Description)
                   .HasColumnType("TEXT");
        }
    

}
