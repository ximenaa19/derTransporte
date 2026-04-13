using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace derTransporte.src.modules.authCredentials.Infrastructure.entity;

public class AuthCredentialEntityConfiguration: IEntityTypeConfiguration<AuthCredentialEntity>
{
    public void Configure(EntityTypeBuilder<AuthCredentialEntity> builder)
        {
            builder.ToTable("auth_credentials");
 
            builder.HasKey(x => x.Id);
 
            builder.Property(x => x.Email).IsRequired().HasColumnType("VARCHAR(150)");
            builder.Property(x => x.PasswordHash).IsRequired().HasColumnType("TEXT");
            builder.Property(x => x.LastLogin).HasColumnType("TIMESTAMP");
            builder.Property(x => x.FailedAttempts).HasColumnType("INTEGER");
            builder.Property(x => x.LockUntil).HasColumnType("TIMESTAMP");
            builder.Property(x => x.IsActive).HasColumnType("TINYINT(1)");
 
            // Relación 1:1 con persons
            builder.HasOne(x => x.Person)
                   .WithOne(x => x.AuthCredential)
                   .HasForeignKey<AuthCredentialEntity>(x => x.PersonId);
        }

}
