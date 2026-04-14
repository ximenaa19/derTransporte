using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.assigmentRole.Infrastructure.entity;

public class AssigmentRoleEntityConfiguration : IEntityTypeConfiguration<AssigmentRoleEntity>
{
    public void Configure(EntityTypeBuilder<AssigmentRoleEntity> builder)
    {
            builder.ToTable("assignment_role");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasColumnType("VARCHAR(100)");
 
            builder.Property(x => x.Description)
                   .HasColumnType("TEXT");
        }

}
