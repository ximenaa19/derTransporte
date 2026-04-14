using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.personStatus.Infrastructure.entity;

public class PersonStatusEntityConfiguration: IEntityTypeConfiguration<PersonStatusEntity>
{
    public void Configure(EntityTypeBuilder<PersonStatusEntity> builder)
    {
            builder.ToTable("person_status");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasColumnType("VARCHAR(100)");
 
            builder.Property(x => x.Description)
                   .HasColumnType("TEXT");
        }

}
