using System;
using derTransporte.src.modules.authCredentials.Infrastructure.entity;
using derTransporte.src.modules.customers.Infrastructure.entity;
using derTransporte.src.modules.drivers.Infrastructure.entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.persons.Infrastructure.entity;

public class PersonEntityConfiguration : IEntityTypeConfiguration<PersonEntity>
{
    public void Configure(EntityTypeBuilder<PersonEntity> builder)
    {
            builder.ToTable("persons");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.FirstName).IsRequired().HasColumnType("VARCHAR (60)");
            builder.Property(x => x.LastName).IsRequired().HasColumnType("VARCHAR (60)");
            builder.Property(x => x.Email).HasColumnType("VARCHAR (60)");
            builder.Property(x => x.Phone).HasColumnType("VARCHAR (60)");
            builder.Property(x => x.IdentificationNumber).HasColumnType("INTEGER");
            builder.Property(x => x.IsVerified).HasColumnType("tinyint(1)");
            builder.Property(x => x.CreatedAt).HasColumnType("DATE");
 
            // Relación N:1 → muchas persons viven en una city
            builder.HasOne(x => x.City)
                   .WithMany()
                   .HasForeignKey(x => x.CityId);
 
            // Relación N:1 → tipo de documento de identidad
            builder.HasOne(x => x.IdentificationType)
                   .WithMany()
                   .HasForeignKey(x => x.IdentificationTypeId);
 
            // Relación N:1 → estado de la persona
            builder.HasOne(x => x.PersonStatus)
                   .WithMany()
                   .HasForeignKey(x => x.PersonStatusId);
 
            // Relación 1:1 → una persona puede ser driver
            builder.HasOne(x => x.Driver)
                   .WithOne(x => x.Person)
                   .HasForeignKey<DriverEntity>(x => x.PersonId);
 
            // Relación 1:1 → una persona puede ser customer
            builder.HasOne(x => x.Customer)
                   .WithOne(x => x.Person)
                   .HasForeignKey<CustomerEntity>(x => x.PersonId);
 
            // Relación 1:1 → una persona tiene credenciales de auth
            builder.HasOne(x => x.AuthCredential)
                   .WithOne(x => x.Person)
                   .HasForeignKey<AuthCredentialEntity>(x => x.PersonId);
        }
}
