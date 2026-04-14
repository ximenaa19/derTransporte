using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.personRoles.Infrastructure.entity;

public class PersonRolesEntityConfiguration: IEntityTypeConfiguration<PersonRolesEntity>
{
    public void Configure(EntityTypeBuilder<PersonRolesEntity> builder)
    {
            builder.ToTable("person_roles");
 
            builder.HasKey(x => x.Id);
 
            // Índice único compuesto para evitar que una persona
            // tenga el mismo rol asignado dos veces
            builder.HasIndex(x => new { x.PersonId, x.RoleId })
                   .IsUnique();
 
            builder.HasOne(x => x.Person)
                   .WithMany()
                   .HasForeignKey(x => x.PersonId);
 
            /*builder.HasOne(x => x.Role)
                   .WithMany()
                   .HasForeignKey(x => x.RoleId);*/
        }

}
